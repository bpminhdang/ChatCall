using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;

namespace ChatApp
{
    public partial class VideoServer : Form
    {
        private TcpListener serverPic;
        private TcpClient clientPic;
        private NetworkStream streamPic;
        private VideoCapture capture;
        string Type;
        public VideoServer(string Type)
        {
            InitializeComponent();
            this.Type = Type;
        }

        private void VideoClient_Load(object sender, EventArgs e)
        {
            if (Type == "Call")
            {
                capture = new VideoCapture();
                serverPic = new TcpListener(IPAddress.Any, 8082);
            }
            else
            {
                pictureBox2.Visible = false;
                serverPic = new TcpListener(IPAddress.Any, 8083);
            }

            serverPic.Start();
            Task.Run(() =>
            {
                while (true)
                {
                    // Chờ đợi kết nối từ client
                    clientPic = serverPic.AcceptTcpClient();
                    // Lấy stream để đọc và ghi dữ liệu
                    streamPic = clientPic.GetStream();
                    while (clientPic.Connected)
                    {
                        Task.Run(() =>
                        {
                            if (Type == "Call")
                                ScreenshotSend(); //CallSend() neu test 2 may
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
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                    pictureBox1.Image = image;
                                }
                            }
                            catch { }
                        }
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

        private void CallSend()
        {
            Mat frame = new Mat();
            capture.Read(frame);
            pictureBox2.Image = BitmapConverter.ToBitmap(frame);
            Byte[] imageBytes = frame.ToBytes();
            streamPic.Write(imageBytes, 0, imageBytes.Length);
        }

        private void VideoServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            streamPic.Dispose();
            clientPic.Close();
            serverPic.Stop();
        }
    }
}
