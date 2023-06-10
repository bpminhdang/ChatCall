using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ChatApp
{
    public partial class Server1 : Form
    {
        VideoCapture capture = new VideoCapture(0);

        TcpListener tcpListener;
        IPEndPoint ipepServer;
        NetworkStream netStream;
        public Server1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        //byte[] Serialize(object obj)
        //{
        //    MemoryStream stream = new MemoryStream();
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    binaryFormatter.Serialize(stream, obj);
        //    return stream.ToArray();
        //}

        //// Hàm gom mảnh
        //object Deserialize(byte[] data)
        //{
        //    MemoryStream stream = new MemoryStream(data);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    return binaryFormatter.Deserialize(stream);
        //}


        //void Receive(object obj)
        //{
        //    Socket client = obj as Socket;
        //    while (true)
        //    {
        //        byte[] data = new byte[1024 * 8080];
        //        client.Receive(data);
        //        string message = (string)Deserialize(data);
        //        rtb_MessageServer.Text += message;

        //    }
        //}

        //void Connect()
        //{
        //    IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
        //    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    server.Bind(IP);
        //    Thread Listen = new Thread(() =>
        //    {
        //        while (true)
        //        {
        //            server.Listen(100);
        //            Socket client = server.Accept();
        //            byte[] dt = new byte[1024 * 8080];
        //            client.Receive(dt);
        //            string message = (string)Deserialize(dt);
        //            client.Send(Serialize(message));
        //            rtb_MessageServer.Text += message;
        //            Thread receive = new Thread(Receive);
        //            receive.IsBackground = true;
        //            receive.Start(client);
        //        }
        //    });
        //    Listen.IsBackground = true;
        //    Listen.Start();
        //}

        //private void bt_Listen_Click(object sender, EventArgs e)
        //{
        //    Socket socket;
        //    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
        //    MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Connect();
        //    bt_Listen.Enabled = false;
        //}




        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void bt_Call_Click(object sender, EventArgs e)
        {
           timer1.Start();

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

        private void bt_Listen_Click(object sender, EventArgs e)
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
                    rtb_MessageServer.Text += " Connected!\n";
                    //ReceiveMessage(tcpClient.Client);
                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }

        private void ReceiveVideo(TcpClient tcpClient)
        {
            Task.Run(() =>
            {
                byte[] recv = new byte[1024];
                while (tcpClient.Connected)
                {
                    NetworkStream stream = tcpClient.GetStream();
                    byte[] imageBytes = new byte[tcpClient.ReceiveBufferSize];
                    int bytesRead = stream.Read(imageBytes, 0, imageBytes.Length);
                    using (MemoryStream memoryStream = new MemoryStream(imageBytes, 0, bytesRead))
                    {
                        Image image = Image.FromStream(memoryStream, true);
                        ptb_Video.Image = image;
                    }

                }
            });
        }

        private void ReceiveMessage(Socket tcpClient_Client)
        {
            Task.Run(() =>
            {
                byte[] recv = new byte[1];
                while (tcpClient_Client.Connected)
                {
                    string Chr;
                    string temp = "";
                    while (true)
                    {

                        tcpClient_Client.Receive(recv);
                        Chr = Encoding.UTF8.GetString(recv);
                        if (Chr == "\n")
                            break;
                        temp += Chr;
                    }
                    rtb_MessageServer.Text += temp + "\n";
                }
            });
        }

        public void messageSend(string message)
        {
            if (netStream != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                netStream.Write(data, 0, data.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messageSend(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Read(frame);
            ptb_Video.Image = BitmapConverter.ToBitmap(frame);
            VideoSend(ptb_Video.Image);
        }
    }
}