using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Libs.TagLib.Jpeg;
using VisioForge.MediaFramework.ONVIF;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace ChatApp
{
    public partial class Client : Form
    {
        VideoCapture capture = new VideoCapture(0);
        TcpClient tcpClient = new TcpClient();
        NetworkStream netStream;
        MemoryStream ms;
        public Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //bt_Disconnect.Enabled = false;
        }



        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 9000);
                tcpClient.Connect(ipEndPoint);
                netStream = tcpClient.GetStream();
                ReceiveMessage(tcpClient.Client);
            }
            catch
            {
                return;
            }
        }

      

        public void ReceiveMessage(Socket tcpClient_Client)
        {
            Task.Run(() =>
            {
                byte[] recv = new byte[1];
                bool isRunning = true;

                string receiveType = "Message";  //Khi nhận được command sẽ đổi biến receive type và không nhận message nữa
                while (tcpClient_Client.Connected)
                {
                    if (receiveType == "Message")
                    {
                        string Chr = "";
                        string temp = "";
                        while (Chr != "\n")
                        {

                            tcpClient_Client.Receive(recv);
                            Chr = Encoding.UTF8.GetString(recv);
                            temp += Chr;
                        }
                        if (temp.StartsWith("//Call")) 
                        {
                            receiveType = "Call";
                            btCall.Text = "Stop";
                            continue;
                        }
                        else if (temp.StartsWith("//Screen"))
                        {
                            receiveType = "Screen";
                            btScreenShare.Text = "Stop";
                            continue;
                        }
                        rtbRecv.Text += temp;
                        rtbSend.Text += "\n";
                    }
                    else if (receiveType == "Call")
                    {
                        ptbImage.BringToFront();
                        ReceiveVideo(tcpClient_Client);
                        //Khi dừng nhận video sẽ đổi biến ReceiveType và tiếp tục nhân message
                        ptbImage.SendToBack();
                        receiveType = "Message";
                    }
                    else if (receiveType == "Screen")
                    {
                        ptbImage.BringToFront();
                        ReceiveVideo(tcpClient_Client);
                        //Khi dừng nhận video sẽ đổi biến ReceiveType và tiếp tục nhân message
                        ptbImage.SendToBack();
                        receiveType = "Message";
                    }
                }

            });
        }

        /// <summary>
        /// Dùng khi nhận được message call hoặc share màn hình, dừng khi nhấn nút stop
        /// </summary>
        /// <param name="client"></param>
        private void ReceiveVideo(Socket client)
        {
            while (client.Connected && (btCall.Text == "Stop" || btScreenShare.Text == "Stop"))
            {
                if (netStream != null)
                {
                    byte[] imageBytes = new byte[100000];
                    netStream.Read(imageBytes, 0, imageBytes.Length);
                    try
                    {
                        ms = new MemoryStream(imageBytes);
                        Image image = Image.FromStream(ms);
                        ptbImage.Image = image;
                    }
                    catch {  }
                }
            }

        }


        public void messageSend(string dataS)
        {
            if (netStream != null)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(dataS + "\n");
                netStream.Write(data, 0, data.Length);
                rtbSend.Text += tbMessage.Text + "\n";
            }
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            messageSend(tbMessage.Text);
            tbMessage.Clear();
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            if (btCall.Text == "Stop")
            {
                messageSend("//Stop"); //Cần xử lý hàm nhận bên server để dừng share
                btCall.Text = "Call";
            }
        }

        private void btScreenShare_Click(object sender, EventArgs e)
        {
            if (btScreenShare.Text == "Stop")
            {
                messageSend("//Stop"); //Cần xử lý hàm nhận bên server để dừng share
                btScreenShare.Text = "Screen share";
            }
        }

    }
}
