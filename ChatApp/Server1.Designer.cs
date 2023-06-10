namespace ChatApp
{
    partial class Server1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bt_Listen = new Button();
            bt_Call = new Button();
            ptb_Video = new PictureBox();
            rtb_MessageServer = new RichTextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ptb_Video).BeginInit();
            SuspendLayout();
            // 
            // bt_Listen
            // 
            bt_Listen.Location = new Point(567, 39);
            bt_Listen.Name = "bt_Listen";
            bt_Listen.Size = new Size(112, 34);
            bt_Listen.TabIndex = 0;
            bt_Listen.Text = "Listen";
            bt_Listen.UseVisualStyleBackColor = true;
            bt_Listen.Click += bt_Listen_Click;
            // 
            // bt_Call
            // 
            bt_Call.Location = new Point(567, 79);
            bt_Call.Name = "bt_Call";
            bt_Call.Size = new Size(112, 34);
            bt_Call.TabIndex = 1;
            bt_Call.Text = "Call";
            bt_Call.UseVisualStyleBackColor = true;
            bt_Call.Click += bt_Call_Click;
            // 
            // ptb_Video
            // 
            ptb_Video.Location = new Point(338, 191);
            ptb_Video.Name = "ptb_Video";
            ptb_Video.Size = new Size(405, 185);
            ptb_Video.TabIndex = 2;
            ptb_Video.TabStop = false;
            // 
            // rtb_MessageServer
            // 
            rtb_MessageServer.Location = new Point(45, 63);
            rtb_MessageServer.Name = "rtb_MessageServer";
            rtb_MessageServer.Size = new Size(229, 313);
            rtb_MessageServer.TabIndex = 3;
            rtb_MessageServer.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(528, 144);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(rtb_MessageServer);
            Controls.Add(ptb_Video);
            Controls.Add(bt_Call);
            Controls.Add(bt_Listen);
            Name = "Server";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptb_Video).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_Listen;
        private Button bt_Call;
        private PictureBox ptb_Video;
        private RichTextBox rtb_MessageServer;
        private TextBox textBox1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}