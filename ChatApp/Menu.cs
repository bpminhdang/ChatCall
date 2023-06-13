using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ChatApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            Client client = new Client();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ClientOld client = new ClientOld();
            //client.Show();
        }

        private void btServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
