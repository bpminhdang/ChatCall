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
            rtbRecv = new RichTextBox();
            lbStatus = new Label();
            tbMessage = new TextBox();
            btListen = new Addon_Custom_Button();
            btCall = new Addon_Custom_Button();
            btScreenShare = new Addon_Custom_Button();
            btSend = new Addon_Custom_Button();
            SuspendLayout();
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Location = new Point(22, 71);
            rtbRecv.Margin = new Padding(2);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(341, 319);
            rtbRecv.TabIndex = 1;
            rtbRecv.Text = "";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.FromArgb(255, 104, 40);
            lbStatus.Location = new Point(32, 36);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(68, 20);
            lbStatus.TabIndex = 3;
            lbStatus.Text = "lbStatus";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(22, 457);
            tbMessage.Margin = new Padding(2);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(713, 27);
            tbMessage.TabIndex = 4;
            // 
            // btListen
            // 
            btListen.BackColor = Color.FromArgb(255, 143, 7);
            btListen.BackgroundColor = Color.FromArgb(255, 143, 7);
            btListen.BorderColor = Color.PaleVioletRed;
            btListen.BorderRadius = 30;
            btListen.BorderSize = 0;
            btListen.FlatAppearance.BorderSize = 0;
            btListen.FlatStyle = FlatStyle.Flat;
            btListen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btListen.ForeColor = Color.FromArgb(252, 249, 248);
            btListen.Location = new Point(751, 22);
            btListen.Margin = new Padding(2);
            btListen.Name = "btListen";
            btListen.Size = new Size(127, 48);
            btListen.TabIndex = 8;
            btListen.Text = "Listen";
            btListen.TextColor = Color.FromArgb(252, 249, 248);
            btListen.UseVisualStyleBackColor = false;
            btListen.Click += btListen_Click;
            // 
            // btCall
            // 
            btCall.BackColor = Color.FromArgb(255, 104, 40);
            btCall.BackgroundColor = Color.FromArgb(255, 104, 40);
            btCall.BorderColor = Color.Transparent;
            btCall.BorderRadius = 30;
            btCall.BorderSize = 1;
            btCall.FlatAppearance.BorderSize = 0;
            btCall.FlatStyle = FlatStyle.Flat;
            btCall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCall.ForeColor = Color.FromArgb(255, 220, 194);
            btCall.Location = new Point(624, 22);
            btCall.Margin = new Padding(2);
            btCall.Name = "btCall";
            btCall.Size = new Size(122, 48);
            btCall.TabIndex = 9;
            btCall.Text = "Call";
            btCall.TextColor = Color.FromArgb(255, 220, 194);
            btCall.UseVisualStyleBackColor = false;
            btCall.Click += btCall_Click;
            // 
            // btScreenShare
            // 
            btScreenShare.BackColor = Color.FromArgb(255, 104, 40);
            btScreenShare.BackgroundColor = Color.FromArgb(255, 104, 40);
            btScreenShare.BorderColor = Color.Transparent;
            btScreenShare.BorderRadius = 30;
            btScreenShare.BorderSize = 1;
            btScreenShare.FlatAppearance.BorderSize = 0;
            btScreenShare.FlatStyle = FlatStyle.Flat;
            btScreenShare.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btScreenShare.ForeColor = Color.FromArgb(255, 220, 194);
            btScreenShare.Location = new Point(497, 22);
            btScreenShare.Margin = new Padding(2);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(122, 48);
            btScreenShare.TabIndex = 10;
            btScreenShare.Text = "Screen share";
            btScreenShare.TextColor = Color.FromArgb(255, 220, 194);
            btScreenShare.UseVisualStyleBackColor = false;
            btScreenShare.Click += btScreenShare_Click;
            // 
            // btSend
            // 
            btSend.BackColor = Color.FromArgb(255, 143, 7);
            btSend.BackgroundColor = Color.FromArgb(255, 143, 7);
            btSend.BorderColor = Color.PaleVioletRed;
            btSend.BorderRadius = 30;
            btSend.BorderSize = 0;
            btSend.FlatAppearance.BorderSize = 0;
            btSend.FlatStyle = FlatStyle.Flat;
            btSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.ForeColor = Color.FromArgb(252, 249, 248);
            btSend.Location = new Point(751, 446);
            btSend.Margin = new Padding(2);
            btSend.Name = "btSend";
            btSend.Size = new Size(127, 48);
            btSend.TabIndex = 24;
            btSend.Text = "Send";
            btSend.TextColor = Color.FromArgb(252, 249, 248);
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += btSend_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(901, 505);
            Controls.Add(btSend);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btListen);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Controls.Add(rtbRecv);
            Margin = new Padding(2);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbRecv;
        private Label lbStatus;
        private TextBox tbMessage;
        private Addon_Custom_Button btListen;
        private Addon_Custom_Button btCall;
        private Addon_Custom_Button btScreenShare;
        private Addon_Custom_Button btSend;
    }
}