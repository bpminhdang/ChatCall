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
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ChatTCP
{
    public partial class Server : Form
    {
        VideoCapture capture = new VideoCapture(0);
       
        IPEndPoint IP;
        Socket server;
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void AddMessage(string message)
        {
            rtb_MessageServer.Text += message;
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        // Hàm gom mảnh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(stream);
        }


        void Receive(object obj)
        {
            Socket client = obj as Socket;
            while (true)
            {
                byte[] data = new byte[1024 * 8080];
                client.Receive(data);
                string message = (string)Deserialize(data);
                AddMessage(message);
            }
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                while (true)
                {
                    server.Listen(100);
                    Socket client = server.Accept();
                    byte[] dt = new byte[1024 * 8080];
                    client.Receive(dt);
                    string message = (string)Deserialize(dt);
                    client.Send(Serialize(message));
                    AddMessage(message);
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(client);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMessage("Get started!\n");
            Connect();
            bt_Listen.Enabled = false;
        }

        private async Task bt_Call_ClickAsync(object sender, EventArgs e)
        {
            while (true)
            {
                Mat frame = new Mat();
                capture.Read(frame);
                ptb_Video.Image = BitmapConverter.ToBitmap(frame);
                await Task.Delay(33);
            }
        }
    }
}
