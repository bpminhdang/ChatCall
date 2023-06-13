using System.Net.Sockets;
using System.Net;

namespace ChatApp
{
    public partial class Server : Form
    {
        private TcpListener serverMess;
        private TcpClient clientMess;
        private NetworkStream streamMess;
        private StreamReader readerMess;
        private StreamWriter writerMess;
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }


        private void btListen_Click(object sender, EventArgs e)
        {
            // Khởi tạo server và bắt đầu lắng nghe kết nối
            serverMess = new TcpListener(IPAddress.Any, 8081);
            serverMess.Start();

            Task.Run(() => ListenForClientsMess());

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
                    if (message != null)
                    {
                        if (message == "//Call")
                            btCall.Text = "Accept";
                        else if (message == "//Screen share")
                            btScreenShare.Text = "Accept";
                        else
                            rtbRecv.Text += message + "\n";
                    }
                }
            }
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
                IPEndPoint clientEndPoint = (IPEndPoint)clientMess.Client.RemoteEndPoint;
                // Lấy địa chỉ IP của client
                string clientIPAddress = clientEndPoint.Address.ToString();
                VideoClient videoClient = new VideoClient(clientIPAddress, "Call");
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
                IPEndPoint clientEndPoint = (IPEndPoint)clientMess.Client.RemoteEndPoint;
                // Lấy địa chỉ IP của client
                string clientIPAddress = clientEndPoint.Address.ToString();
                VideoClient videoClient = new VideoClient(clientIPAddress, "Screen share");
                videoClient.Show();
                btScreenShare.Text = "Screen share";

            }
        }


        private void btSend_Click(object sender, EventArgs e)
        {
            messageSend(tbMessage.Text);
            tbMessage.Clear();
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                messageSend(tbMessage.Text);
                e.SuppressKeyPress = true;
            }
        }
        private void messageSend(string s)
        {
            if (writerMess != null)
            {
                writerMess.WriteLine(s);
                writerMess.Flush();
            }
        }


    }

}