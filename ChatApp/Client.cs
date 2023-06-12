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
        VideoCapture capture;
        TcpClient clientMess;
        TcpClient clientPic;
        StreamReader readerMess;
        StreamWriter writerMess;
        NetworkStream streamPic;
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
                clientMess.Connect(textBox1.Text, 10000);
                clientPic = new TcpClient();
                clientPic.Connect(textBox1.Text, 10001);
                streamPic = clientPic.GetStream();
                readerMess = new StreamReader(clientMess.GetStream());
                writerMess = new StreamWriter(clientMess.GetStream());
                lbStatus.Text = "Connected!";

                Task.Run(() =>
                {
                    while (true)
                    {
                        string data = readerMess.ReadLine();
                        if (data == "//Call")
                        {
                            //DialogResult dg = MessageBox.Show("Call", "Call request", MessageBoxButtons.YesNo);
                            //if (dg == DialogResult.Yes)
                            //{
                            //    Call();
                            //}
                            Call();
                        }
                        rtbRecv.Text += data + "\n";
                    }
                });
                Task.Run(() =>
                {
                    while (clientPic.Connected)
                    {
                        if (streamPic != null)
                        {
                            StopTimer(ScreenTimer);
                            //StopTimer(VideoTimer);
                            byte[] imageBytes = new byte[10000000];
                            streamPic.Read(imageBytes, 0, imageBytes.Length);
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);
                                    ptbImage.Image = image;
                                    MessageBox.Show("Client nhan 1 anh");

                                }
                            }
                            catch (Exception ex) { continue; }
                        }
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
        }

        private void messageSend(string s)
        {
            // Gửi dữ liệu từ textbox đến client khi người dùng nhấn nút
            if (writerMess != null)
            {
                writerMess.WriteLine(s);
                writerMess.Flush();
            }
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            Call();
            messageSend("//Call");

        }

        private void Call()
        {
            ptbYou.Visible = true;
            StopTimer(ScreenTimer);
            StartTimer(VideoTimer);
        }


        private void btScreenShare_Click(object sender, EventArgs e)
        {
            StopTimer(VideoTimer);
            StartTimer(ScreenTimer);
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

        private void VideoTimer_Tick(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Read(frame);
            ptbYou.Image = BitmapConverter.ToBitmap(frame);
            Byte[] imageBytes = frame.ToBytes();
            streamPic.Write(imageBytes, 0, imageBytes.Length);
            MessageBox.Show("Client gui 1 anh");

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
                streamPic.Write(imageBytes, 0, imageBytes.Length);

            }
            ptbImage.Image = screenShot;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
        }

        public void StartTimer(System.Windows.Forms.Timer timer)
        {
            this.Invoke((MethodInvoker)delegate
            {
                timer.Start();
            });

        }

        public void StopTimer(System.Windows.Forms.Timer timer)
        {
            this.Invoke((MethodInvoker)delegate
            {
                timer.Stop();
            });

        }
    }
}
