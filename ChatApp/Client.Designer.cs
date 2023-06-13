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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            tbMessage = new TextBox();
            lbStatus = new Label();
            rtbRecv = new RichTextBox();
            textBox1 = new TextBox();
            btScreenShare = new Addon_Custom_Button();
            btCall = new Addon_Custom_Button();
            btConnect = new Addon_Custom_Button();
            btSend = new Addon_Custom_Button();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(11, 457);
            tbMessage.Margin = new Padding(2);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(711, 27);
            tbMessage.TabIndex = 13;
            tbMessage.KeyDown += tbMessage_KeyDown;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.FromArgb(190, 0, 52);
            lbStatus.Location = new Point(20, 36);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(68, 20);
            lbStatus.TabIndex = 12;
            lbStatus.Text = "lbStatus";
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Location = new Point(11, 85);
            rtbRecv.Margin = new Padding(2);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(414, 353);
            rtbRecv.TabIndex = 10;
            rtbRecv.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(104, 33);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 19;
            textBox1.Text = "127.0.0.1";
            // 
            // btScreenShare
            // 
            btScreenShare.BackColor = Color.FromArgb(190, 0, 52);
            btScreenShare.BackgroundColor = Color.FromArgb(190, 0, 52);
            btScreenShare.BorderColor = Color.Transparent;
            btScreenShare.BorderRadius = 30;
            btScreenShare.BorderSize = 1;
            btScreenShare.FlatAppearance.BorderSize = 0;
            btScreenShare.FlatStyle = FlatStyle.Flat;
            btScreenShare.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btScreenShare.ForeColor = Color.FromArgb(255, 218, 214);
            btScreenShare.Location = new Point(509, 22);
            btScreenShare.Margin = new Padding(2);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(122, 48);
            btScreenShare.TabIndex = 22;
            btScreenShare.Text = "Screen share";
            btScreenShare.TextColor = Color.FromArgb(255, 218, 214);
            btScreenShare.UseVisualStyleBackColor = false;
            btScreenShare.Click += btScreenShare_Click;
            // 
            // btCall
            // 
            btCall.BackColor = Color.FromArgb(190, 0, 52);
            btCall.BackgroundColor = Color.FromArgb(190, 0, 52);
            btCall.BorderColor = Color.Transparent;
            btCall.BorderRadius = 30;
            btCall.BorderSize = 1;
            btCall.FlatAppearance.BorderSize = 0;
            btCall.FlatStyle = FlatStyle.Flat;
            btCall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCall.ForeColor = Color.FromArgb(255, 218, 214);
            btCall.Location = new Point(636, 22);
            btCall.Margin = new Padding(2);
            btCall.Name = "btCall";
            btCall.Size = new Size(122, 48);
            btCall.TabIndex = 21;
            btCall.Text = "Call";
            btCall.TextColor = Color.FromArgb(255, 218, 214);
            btCall.UseVisualStyleBackColor = false;
            btCall.Click += btCall_Click;
            // 
            // btConnect
            // 
            btConnect.BackColor = Color.FromArgb(255, 60, 76);
            btConnect.BackgroundColor = Color.FromArgb(255, 60, 76);
            btConnect.BorderColor = Color.PaleVioletRed;
            btConnect.BorderRadius = 30;
            btConnect.BorderSize = 0;
            btConnect.FlatAppearance.BorderSize = 0;
            btConnect.FlatStyle = FlatStyle.Flat;
            btConnect.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btConnect.ForeColor = Color.FromArgb(252, 249, 248);
            btConnect.Location = new Point(763, 22);
            btConnect.Margin = new Padding(2);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(127, 48);
            btConnect.TabIndex = 20;
            btConnect.Text = "Connect";
            btConnect.TextColor = Color.FromArgb(252, 249, 248);
            btConnect.UseVisualStyleBackColor = false;
            btConnect.Click += btConnect_Click;
            // 
            // btSend
            // 
            btSend.BackColor = Color.FromArgb(255, 60, 76);
            btSend.BackgroundColor = Color.FromArgb(255, 60, 76);
            btSend.BorderColor = Color.PaleVioletRed;
            btSend.BorderRadius = 30;
            btSend.BorderSize = 0;
            btSend.FlatAppearance.BorderSize = 0;
            btSend.FlatStyle = FlatStyle.Flat;
            btSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.ForeColor = Color.FromArgb(252, 249, 248);
            btSend.Location = new Point(763, 446);
            btSend.Margin = new Padding(2);
            btSend.Name = "btSend";
            btSend.Size = new Size(127, 48);
            btSend.TabIndex = 23;
            btSend.Text = "Send";
            btSend.TextColor = Color.FromArgb(252, 249, 248);
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += bt_Send_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 252, 246);
            ClientSize = new Size(901, 505);
            Controls.Add(btSend);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btConnect);
            Controls.Add(textBox1);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Controls.Add(rtbRecv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbMessage;
        private Label lbStatus;
        private RichTextBox rtbRecv;
        private TextBox textBox1;
        private Addon_Custom_Button btScreenShare;
        private Addon_Custom_Button btCall;
        private Addon_Custom_Button btConnect;
        private Addon_Custom_Button btSend;
    }
}