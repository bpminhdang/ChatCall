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
        private TcpListener serverMess;
        private TcpClient clientMess;
        private NetworkStream streamMess;
        private StreamReader readerMess;
        private StreamWriter writerMess;
        VideoCapture capture;

        private TcpListener serverPic;
        private TcpClient clientPic;
        private NetworkStream streamPic;
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }


        private void btListen_Click(object sender, EventArgs e)
        {
            // Khởi tạo server và bắt đầu lắng nghe kết nối
            serverMess = new TcpListener(IPAddress.Any, 10000);
            serverMess.Start();
            serverPic = new TcpListener(IPAddress.Any, 10001);
            serverPic.Start();
            // Khởi tạo task để lắng nghe kết nối và dữ liệu từ client
            Task.Run(() => ListenForClientsMess());
            Task.Run(() => ListenForClientsPic());
        }

        private void ListenForClientsMess()
        {
            while (true)
            {
                // Chờ đợi kết nối từ client
                clientMess = serverMess.AcceptTcpClient();
                lbStatus.Text = "Connected!";
                // Lấy stream để đọc và ghi dữ liệu
                streamMess = clientMess.GetStream();
                readerMess = new StreamReader(streamMess);
                writerMess = new StreamWriter(streamMess);

                // Đọc dữ liệu từ client
                string message = "";
                while (message != null)
                {
                    message = readerMess.ReadLine();
                    if (message == "//Call")
                    {
                        //DialogResult dg = MessageBox.Show("Call", "Call request", MessageBoxButtons.YesNo);
                        //if (dg == DialogResult.Yes)
                        //{
                        //    Call();
                        //}
                        Call();
                    }
                    //else
                    rtbRecv.Text += message + "\n";

                }
            }
        }

        private void ListenForClientsPic()
        {
            while (true)
            {
                // Chờ đợi kết nối từ client
                clientPic = serverPic.AcceptTcpClient();
                // Lấy stream để đọc và ghi dữ liệu
                streamPic = clientPic.GetStream();
                while (clientPic.Connected)
                {
                    if (streamPic != null)
                    {
                        //StopTimer(VideoTimer);
                        StopTimer(ScreenTimer);
                        byte[] imageBytes = new byte[10000000];
                        streamPic.Read(imageBytes, 0, imageBytes.Length);
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                ptbImage.Image = image;
                                int temp = int.Parse(label1.Text);
                                    temp++;
                                label1.Text = temp.ToString();
                                //MessageBox.Show("Server nhan 1 anh");

                            }
                        }
                        catch (Exception ex) {
                            int temp = 0;
                            label1.Text = temp.ToString(); continue; }

                    }
                }
            }
        }

        private void VideoTimer_Tick(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Read(frame);
            ptbYou.Image = BitmapConverter.ToBitmap(frame);
            Byte[] imageBytes = frame.ToBytes();
            streamPic.Write(imageBytes, 0, imageBytes.Length);
            //  MessageBox.Show("Server gui 1 anh");

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
            ptbYou.Image = screenShot;
        }


        private void btCall_Click(object sender, EventArgs e)
        {
            Call();
            messageSend("//Call");
        }

        private void Call()
        {
            ptbYou.Visible = true;
            // MessageBox.Show("Video timer cua Server bat");
            StopTimer(ScreenTimer);
            StartTimer(VideoTimer);
        }

        private void btScreenShare_Click(object sender, EventArgs e)
        {
            ptbYou.Visible = false;
            StopTimer(VideoTimer);
            StartTimer(ScreenTimer);
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

        private void messageSend(string s)
        {
            // Gửi dữ liệu từ textbox đến client khi người dùng nhấn nút
            if (writerMess != null)
            {
                writerMess.WriteLine(s);
                writerMess.Flush();
            }
        }

        private void Server_Load(object sender, EventArgs e)
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