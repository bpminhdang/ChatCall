namespace ChatApp
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            lbStatus = new Label();
            tbMessage = new TextBox();
            btSend = new Addon_Custom_Button();
            btScreenShare = new Addon_Custom_Button();
            btCall = new Addon_Custom_Button();
            btListen = new Addon_Custom_Button();
            rtbSend = new RichTextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            rtbRecv = new RichTextBox();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.FromArgb(160, 63, 40);
            lbStatus.Location = new Point(40, 45);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 25);
            lbStatus.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(28, 571);
            tbMessage.Margin = new Padding(2);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(890, 31);
            tbMessage.TabIndex = 4;
            tbMessage.KeyDown += tbMessage_KeyDown;
            // 
            // btSend
            // 
            btSend.BackColor = Color.FromArgb(160, 63, 40);
            btSend.BackgroundColor = Color.FromArgb(160, 63, 40);
            btSend.BorderColor = Color.PaleVioletRed;
            btSend.BorderRadius = 30;
            btSend.BorderSize = 0;
            btSend.FlatAppearance.BorderSize = 0;
            btSend.FlatStyle = FlatStyle.Flat;
            btSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.ForeColor = Color.FromArgb(252, 249, 248);
            btSend.Location = new Point(940, 542);
            btSend.Name = "btSend";
            btSend.Size = new Size(159, 60);
            btSend.TabIndex = 32;
            btSend.Text = "Send";
            btSend.TextColor = Color.FromArgb(252, 249, 248);
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += btSend_Click;
            // 
            // btScreenShare
            // 
            btScreenShare.BackColor = Color.White;
            btScreenShare.BackgroundColor = Color.White;
            btScreenShare.BorderColor = Color.FromArgb(142, 126, 122);
            btScreenShare.BorderRadius = 30;
            btScreenShare.BorderSize = 1;
            btScreenShare.FlatAppearance.BorderSize = 0;
            btScreenShare.FlatStyle = FlatStyle.Flat;
            btScreenShare.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btScreenShare.ForeColor = Color.FromArgb(166, 76, 54);
            btScreenShare.Location = new Point(622, 27);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(153, 60);
            btScreenShare.TabIndex = 31;
            btScreenShare.Text = "Screen share";
            btScreenShare.TextColor = Color.FromArgb(166, 76, 54);
            btScreenShare.UseVisualStyleBackColor = false;
            btScreenShare.Click += btScreenShare_Click;
            // 
            // btCall
            // 
            btCall.BackColor = Color.White;
            btCall.BackgroundColor = Color.White;
            btCall.BorderColor = Color.FromArgb(142, 126, 122);
            btCall.BorderRadius = 30;
            btCall.BorderSize = 1;
            btCall.FlatAppearance.BorderSize = 0;
            btCall.FlatStyle = FlatStyle.Flat;
            btCall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCall.ForeColor = Color.FromArgb(166, 76, 54);
            btCall.Location = new Point(781, 27);
            btCall.Name = "btCall";
            btCall.Size = new Size(153, 60);
            btCall.TabIndex = 30;
            btCall.Text = "Call";
            btCall.TextColor = Color.FromArgb(166, 76, 54);
            btCall.UseVisualStyleBackColor = false;
            btCall.Click += btCall_Click;
            // 
            // btListen
            // 
            btListen.BackColor = Color.FromArgb(160, 63, 40);
            btListen.BackgroundColor = Color.FromArgb(160, 63, 40);
            btListen.BorderColor = Color.PaleVioletRed;
            btListen.BorderRadius = 30;
            btListen.BorderSize = 0;
            btListen.FlatAppearance.BorderSize = 0;
            btListen.FlatStyle = FlatStyle.Flat;
            btListen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btListen.ForeColor = Color.FromArgb(252, 249, 248);
            btListen.Location = new Point(940, 27);
            btListen.Name = "btListen";
            btListen.Size = new Size(159, 60);
            btListen.TabIndex = 29;
            btListen.Text = "Listen";
            btListen.TextColor = Color.FromArgb(252, 249, 248);
            btListen.UseVisualStyleBackColor = false;
            btListen.Click += btListen_Click;
            // 
            // rtbSend
            // 
            rtbSend.BorderStyle = BorderStyle.None;
            rtbSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rtbSend.Location = new Point(565, 92);
            rtbSend.Margin = new Padding(2);
            rtbSend.Name = "rtbSend";
            rtbSend.Size = new Size(550, 441);
            rtbSend.TabIndex = 33;
            rtbSend.Text = "";
            rtbSend.TextChanged += rtbSend_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(359, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 33);
            comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(160, 63, 40);
            label2.Location = new Point(209, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 36;
            label2.Text = "Your IP Address";
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rtbRecv.Location = new Point(28, 113);
            rtbRecv.Margin = new Padding(2);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(556, 441);
            rtbRecv.TabIndex = 37;
            rtbRecv.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(1126, 631);
            Controls.Add(rtbRecv);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(rtbSend);
            Controls.Add(btSend);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btListen);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbStatus;
        private TextBox tbMessage;
        private Addon_Custom_Button btSend;
        private Addon_Custom_Button btScreenShare;
        private Addon_Custom_Button btCall;
        private Addon_Custom_Button btListen;
        private RichTextBox rtbSend;
        private ComboBox comboBox1;
        private Label label2;
        private RichTextBox rtbRecv;
    }
}