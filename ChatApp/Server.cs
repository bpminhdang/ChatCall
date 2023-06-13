using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;

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
                        {
                            rtbRecv.Text += "Client: " + message + "\n";
                            rtbSend.Text += "\n";
                        }
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


        private void messageSend(string s)
        {
            if (writerMess != null)
            {
                writerMess.WriteLine(s);
                writerMess.Flush();
                rtbSend.Text += s + " :Server" + "\n";
                rtbRecv.Text += "\n";
            }
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                messageSend(tbMessage.Text);
                tbMessage.Clear();
            }
        }


        private void rtbSend_TextChanged(object sender, EventArgs e)
        {
            rtbSend.SelectAll();
            rtbSend.SelectionAlignment = HorizontalAlignment.Right;
            rtbSend.ScrollToCaret();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            string ipv4Address = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            comboBox1.Items.Add(ip.Address.ToString() + " " + ni.Name.ToString());
                            comboBox1.Text = ip.Address.ToString();
                        }
                    }
                }
                if (!string.IsNullOrEmpty(ipv4Address))
                {
                    break;
                }
            }
        }
    }

}