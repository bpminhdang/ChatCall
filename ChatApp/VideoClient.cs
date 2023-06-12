using OpenCvSharp;
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

        public VideoClient(string ipAddress)
        {
            InitializeComponent();
            this.ipAddress = ipAddress;

        }

        private void VideoClient_Load(object sender, EventArgs e)
        {
            clientPic = new TcpClient();
            clientPic.Connect(ipAddress, 8082);
            streamPic = clientPic.GetStream();
            Task.Run(() =>
            {
                while (clientPic.Connected)
                {
                    Task.Run(() =>
                    {
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

        private void VideoClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            streamPic.Dispose(); 
            clientPic.Close();
        }
    }
}
