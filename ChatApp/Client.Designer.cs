namespace ChatApp
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ptbImage = new PictureBox();
            btScreenShare = new Button();
            btCall = new Button();
            btSend = new Button();
            tbMessage = new TextBox();
            lbStatus = new Label();
            rtbRecv = new RichTextBox();
            btConnect = new Button();
            VideoTimer = new System.Windows.Forms.Timer(components);
            ScreenTimer = new System.Windows.Forms.Timer(components);
            ptbYou = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbYou).BeginInit();
            SuspendLayout();
            // 
            // ptbImage
            // 
            ptbImage.Location = new Point(253, 73);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(482, 393);
            ptbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbImage.TabIndex = 17;
            ptbImage.TabStop = false;
            // 
            // btScreenShare
            // 
            btScreenShare.Location = new Point(521, 19);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(146, 34);
            btScreenShare.TabIndex = 16;
            btScreenShare.Text = "Screen share";
            btScreenShare.UseVisualStyleBackColor = true;
            btScreenShare.Click += btScreenShare_Click;
            // 
            // btCall
            // 
            btCall.Location = new Point(673, 19);
            btCall.Name = "btCall";
            btCall.Size = new Size(112, 34);
            btCall.TabIndex = 15;
            btCall.Text = "Call";
            btCall.UseVisualStyleBackColor = true;
            btCall.Click += btCall_Click;
            // 
            // btSend
            // 
            btSend.Location = new Point(807, 474);
            btSend.Name = "btSend";
            btSend.Size = new Size(112, 34);
            btSend.TabIndex = 14;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += bt_Send_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(14, 476);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(787, 31);
            tbMessage.TabIndex = 13;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(54, 19);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(75, 25);
            lbStatus.TabIndex = 12;
            lbStatus.Text = "lbStatus";
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Location = new Point(14, 95);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(210, 371);
            rtbRecv.TabIndex = 10;
            rtbRecv.Text = "";
            // 
            // btConnect
            // 
            btConnect.Location = new Point(791, 19);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(112, 34);
            btConnect.TabIndex = 9;
            btConnect.Text = "Connect";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // VideoTimer
            // 
            VideoTimer.Interval = 41;
            VideoTimer.Tick += VideoTimer_Tick;
            // 
            // ScreenTimer
            // 
            ScreenTimer.Tick += ScreenTimer_Tick;
            // 
            // ptbYou
            // 
            ptbYou.Location = new Point(741, 343);
            ptbYou.Name = "ptbYou";
            ptbYou.Size = new Size(178, 123);
            ptbYou.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbYou.TabIndex = 18;
            ptbYou.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(753, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 19;
            textBox1.Text = "10.0.138.40";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 28);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 21;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 30);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 22;
            label2.Text = "0";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 526);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ptbYou);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btSend);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Controls.Add(rtbRecv);
            Controls.Add(btConnect);
            Controls.Add(ptbImage);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbYou).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbImage;
        private Button btScreenShare;
        private Button btCall;
        private Button btSend;
        private TextBox tbMessage;
        private Label lbStatus;
        private RichTextBox rtbRecv;
        private Button btConnect;
        private System.Windows.Forms.Timer VideoTimer;
        private System.Windows.Forms.Timer ScreenTimer;
        private PictureBox ptbYou;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}