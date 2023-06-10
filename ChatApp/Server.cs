using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using VisioForge.Types;

namespace ChatApp
{
    public partial class Server : Form
    {
        VideoCapture capture = new VideoCapture(0);
        TcpListener tcpListener;
        IPEndPoint ipepServer;
        NetworkStream netStream;
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }


        private void btListen_Click(object sender, EventArgs e)
        {
            ipepServer = new IPEndPoint(IPAddress.Any, 9000);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            Task.Run(() =>
            {
                AcceptConnection();
            });
        }

        private void AcceptConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    IPEndPoint clientEndPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
                    netStream = tcpClient.GetStream();
                    string clientIPAddress = clientEndPoint.ToString();
                    lbStatus.Text = " Connected!";
                    ReceiveMessage(tcpClient.Client);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private void ReceiveVideo(TcpClient tcpClient)
        //{
        //    Task.Run(() =>
        //    {
        //        byte[] recv = new byte[1024];
        //        while (tcpClient.Connected)
        //        {
        //            NetworkStream stream = tcpClient.GetStream();
        //            byte[] imageBytes = new byte[tcpClient.ReceiveBufferSize];
        //            int bytesRead = stream.Read(imageBytes, 0, imageBytes.Length);
        //            using (MemoryStream memoryStream = new MemoryStream(imageBytes, 0, bytesRead))
        //            {
        //                Image image = Image.FromStream(memoryStream, true);
        //                ptbImage.Image = image;
        //            }

        //        }
        //    });
        //}

        private void ReceiveMessage(Socket tcpClient_Client)
        {
            Task.Run(() =>
            {
                byte[] recv = new byte[1];
                while (tcpClient_Client.Connected)
                {
                    string Chr = "";
                    string temp = "";
                    while (Chr != "\n")
                    {

                        tcpClient_Client.Receive(recv);
                        Chr = Encoding.UTF8.GetString(recv);
                        temp += Chr;
                    }
                    rtbRecv.Text += temp;
                    rtbSend.Text += "\n";
                }
            });
        }

        public void messageSend(string message)
        {
            if (netStream != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                netStream.Write(data, 0, data.Length);
                rtbSend.Text += tbMessage.Text + "\n";
                rtbRecv.Text += "\n";

            }
        }

        private void VideoTimer_Tick(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Read(frame);
            ptbImage.Image = BitmapConverter.ToBitmap(frame);
            VideoSend(ptbImage.Image);
        }

        private void VideoSend(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // lưu đối tượng Image vào MemoryStream với định dạng JPEG
                byte[] imageBytes = ms.ToArray(); // chuyển đổi MemoryStream thành một mảng byte
                netStream.Write(imageBytes, 0, imageBytes.Length);// chuyển đổi MemoryStream thành một mảng byte
            }

        }

        private void btCall_Click(object sender, EventArgs e)
        {
            messageSend("//Call");
            ptbImage.BringToFront();
            Thread.Sleep(1000);
            ScreenTimer.Stop();
            VideoTimer.Start();

        }

        private void btScreenShare_Click(object sender, EventArgs e)
        {
            messageSend("//Screen");
            ptbImage.BringToFront();
            Thread.Sleep(1000);
            VideoTimer.Stop();
            ScreenTimer.Start();
        }

        private void ScreenTimer_Tick(object sender, EventArgs e)
        {
            // Chụp ảnh màn hình hiện tại
            Bitmap screenShot = screenshotGet();
            // Chuyển đổi ảnh sang mảng byte để truyền qua socket
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                screenShot.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
            ptbImage.Image = screenShot;
            VideoSend(ptbImage.Image);
        }

        private Bitmap screenshotGet()
        {
            Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(screenShot))
            {
                g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
            }
            return screenShot;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            messageSend(tbMessage.Text);
        }
    }
}