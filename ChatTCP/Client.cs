using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;

namespace ChatTCP
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            bt_Disconnect.Enabled = false;
        }

        IPEndPoint IP;
        Socket client;

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
                MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Disconnect.Enabled = true;
                bt_Connect.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        void Send()
        {
            if (rtb_Send.Text != string.Empty)
            {
                client.Send(Serialize("From client: " + rtb_Send.Text + "\n"));
            }
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 8080];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                }
            }
            catch
            {
                Close();
            }
        }

        void Disconnect()
        {
            if (client != null && client.Connected)
            {
                MessageBox.Show("Ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Connect.Enabled = true;
                bt_Disconnect.Enabled = false;
            }
        }
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            Send();
            rtb_Send.Clear();
        }
    }
}
