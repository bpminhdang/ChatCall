using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class VideoClient : Form
    {
        //VideoCapture capture;
        TcpClient clientPic;
        NetworkStream streamPic;
        string ipAddress;
        private VideoCapture capture;
        string Type;
        private bool True = true;


        public VideoClient(string ipAddress, string Type)
        {
            InitializeComponent();
            this.ipAddress = ipAddress;
            this.Type = Type;
        }

        private void VideoClient_Load(object sender, EventArgs e)
        {
            clientPic = new TcpClient();
            if (Type == "Call")
            {
                capture = new VideoCapture(0);
                clientPic.Connect(ipAddress, 8082);
            }
            else
            {
                clientPic.Connect(ipAddress, 8083);
                pictureBox2.Visible = false;
            }
            streamPic = clientPic.GetStream();
            Task.Run(() =>
            {
                while (clientPic.Connected)
                {
                    Task.Run(() =>
                    {
                        if (Type == "Call")
                            CallSend();//ScreenshotSend(); //CallSend() neu test 2 may
                        else
                            ScreenshotSend();

                    });
                    if (streamPic != null)
                    {

                        byte[] imageBytes = new byte[10000000];
                        streamPic.Read(imageBytes, 0, imageBytes.Length);
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(ms);
                                pictureBox1.Image = image;
                            }
                        }
                        catch (Exception ex) { continue; }
                    }
                }
            });


        }

        private void ScreenshotSend()
        {
            // Chụp ảnh màn hình hiện tại
            Bitmap screenShot = screenshotGet();
            // Chuyển đổi ảnh sang mảng byte để truyền qua socket
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                screenShot.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
                streamPic.Write(imageBytes, 0, imageBytes.Length);

            }
            pictureBox2.Image = screenShot;
            Thread.Sleep(16);
        }

        private Bitmap screenshotGet()
        {
            System.Drawing.Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(screenShot))
            {
                g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
            }
            return screenShot;
        }

        private void CallSend()
        {
            while (True)
            {
                Mat frame = new Mat();
                capture.Read(frame);
                pictureBox2.Image = BitmapConverter.ToBitmap(frame);
                Byte[] imageBytes = frame.ToBytes();
                streamPic.Write(imageBytes, 0, imageBytes.Length);
                Thread.Sleep(41);
            }
        }


        private void VideoClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            streamPic.Dispose();
            clientPic.Close();
            True = false; //Stop any loop in the form

        }
    }
}
