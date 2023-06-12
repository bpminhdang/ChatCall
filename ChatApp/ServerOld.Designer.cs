namespace ChatApp
{
    partial class ServerOld
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
            btListen = new Button();
            rtbRecv = new RichTextBox();
            rtbSend = new RichTextBox();
            lbStatus = new Label();
            tbMessage = new TextBox();
            btSend = new Button();
            btCall = new Button();
            btScreenShare = new Button();
            ptbImage = new PictureBox();
            VideoTimer = new System.Windows.Forms.Timer(components);
            ScreenTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            SuspendLayout();
            // 
            // btListen
            // 
            btListen.Location = new Point(805, 41);
            btListen.Name = "btListen";
            btListen.Size = new Size(112, 34);
            btListen.TabIndex = 0;
            btListen.Text = "Listen";
            btListen.UseVisualStyleBackColor = true;
            btListen.Click += btListen_Click;
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Location = new Point(28, 117);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(444, 371);
            rtbRecv.TabIndex = 1;
            rtbRecv.Text = "";
            // 
            // rtbSend
            // 
            rtbSend.BorderStyle = BorderStyle.None;
            rtbSend.Location = new Point(489, 117);
            rtbSend.Name = "rtbSend";
            rtbSend.RightToLeft = RightToLeft.Yes;
            rtbSend.Size = new Size(428, 371);
            rtbSend.TabIndex = 2;
            rtbSend.Text = "";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(68, 41);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(75, 25);
            lbStatus.TabIndex = 3;
            lbStatus.Text = "lbStatus";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(28, 498);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(787, 31);
            tbMessage.TabIndex = 4;
            // 
            // btSend
            // 
            btSend.Location = new Point(821, 496);
            btSend.Name = "btSend";
            btSend.Size = new Size(112, 34);
            btSend.TabIndex = 5;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // btCall
            // 
            btCall.Location = new Point(687, 41);
            btCall.Name = "btCall";
            btCall.Size = new Size(112, 34);
            btCall.TabIndex = 6;
            btCall.Text = "Call";
            btCall.UseVisualStyleBackColor = true;
            btCall.Click += btCall_Click;
            // 
            // btScreenShare
            // 
            btScreenShare.Location = new Point(535, 41);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(146, 34);
            btScreenShare.TabIndex = 7;
            btScreenShare.Text = "Screen share";
            btScreenShare.UseVisualStyleBackColor = true;
            btScreenShare.Click += btScreenShare_Click;
            // 
            // ptbImage
            // 
            ptbImage.Location = new Point(28, 89);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(905, 399);
            ptbImage.TabIndex = 8;
            ptbImage.TabStop = false;
            // 
            // VideoTimer
            // 
            VideoTimer.Tick += VideoTimer_Tick;
            // 
            // ScreenTimer
            // 
            ScreenTimer.Interval = 16;
            ScreenTimer.Tick += ScreenTimer_Tick;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 554);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btSend);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Controls.Add(rtbSend);
            Controls.Add(rtbRecv);
            Controls.Add(btListen);
            Controls.Add(ptbImage);
            Name = "Server";
            Text = "Server";
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btListen;
        private RichTextBox rtbRecv;
        private RichTextBox rtbSend;
        private Label lbStatus;
        private TextBox tbMessage;
        private Button btSend;
        private Button btCall;
        private Button btScreenShare;
        private PictureBox ptbImage;
        private System.Windows.Forms.Timer VideoTimer;
        private System.Windows.Forms.Timer ScreenTimer;
    }
}