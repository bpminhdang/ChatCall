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
using Gst.Rtsp;

namespace ChatApp
{
    public partial class Client : Form
    {
        TcpClient clientMess;
        StreamReader readerMess;
        StreamWriter writerMess;
        string ipAddress;
        public Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }



        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                clientMess = new TcpClient();
                clientMess.Connect(textBox1.Text, 8081);
                ipAddress = textBox1.Text;
                readerMess = new StreamReader(clientMess.GetStream());
                writerMess = new StreamWriter(clientMess.GetStream());
                lbStatus.Text = "Connected!";

                Task.Run(() =>
                {
                    while (true)
                    {
                        string message = readerMess.ReadLine();
                        if (message == "//Call")
                            btCall.Text = "Accept";
                        else if (message == "//Screen share")
                            btScreenShare.Text = "Accept";
                        else
                        rtbRecv.Text += message + "\n";
                    }
                });


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bt_Send_Click(object sender, EventArgs e)
        {
            messageSend(tbMessage.Text);
            tbMessage.Clear();
        }

        private void messageSend(string message)
        {
            writerMess.WriteLine(message);
            writerMess.Flush();
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            if (btCall.Text == "Call")
            {
                VideoServer videoServer = new VideoServer("Call");
                videoServer.Show();
                messageSend("//Call");

            }
            else
            {
                VideoClient videoClient = new VideoClient(ipAddress, "Call");
                videoClient.Show();
                btCall.Text = "Call";

            }
        }

        private void btScreenShare_Click(object sender, EventArgs e)
        {
            if (btScreenShare.Text == "Screen share")
            {
                VideoServer videoServer = new VideoServer("Screen share");
                videoServer.Show();
                messageSend("//Screen share");

            }
            else
            {
                VideoClient videoClient = new VideoClient(ipAddress, "Screen share");
                videoClient.Show();
                btScreenShare.Text = "Screen share";
            }
        }



    }
}
