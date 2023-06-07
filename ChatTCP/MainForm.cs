using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTCP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Server sv = new Server();
                sv.ShowDialog();
            });
            thread.Start();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Client cl = new Client();
                cl.ShowDialog();
            });
            thread.Start();
            button2.Enabled = false;
        }
    }
}
