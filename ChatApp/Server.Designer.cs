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
            rtbRecv.Location = new Point(28, 89);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(426, 399);
            rtbRecv.TabIndex = 1;
            rtbRecv.Text = "";
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
            btListen.Location = new Point(939, 28);
            btListen.Name = "btListen";
            btListen.Size = new Size(159, 60);
            btListen.TabIndex = 8;
            btListen.Text = "Listen";
            btListen.TextColor = Color.FromArgb(252, 249, 248);
            btListen.UseVisualStyleBackColor = false;
            btListen.Click += btListen_Click;
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
            btCall.Location = new Point(780, 28);
            btCall.Name = "btCall";
            btCall.Size = new Size(153, 60);
            btCall.TabIndex = 9;
            btCall.Text = "Call";
            btCall.TextColor = Color.FromArgb(166, 76, 54);
            btCall.UseVisualStyleBackColor = false;
            btCall.Click += btCall_Click;
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
            btScreenShare.Location = new Point(621, 28);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(153, 60);
            btScreenShare.TabIndex = 10;
            btScreenShare.Text = "Screen share";
            btScreenShare.TextColor = Color.FromArgb(166, 76, 54);
            btScreenShare.UseVisualStyleBackColor = false;
            btScreenShare.Click += btScreenShare_Click;
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
            btSend.Location = new Point(939, 469);
            btSend.Name = "btSend";
            btSend.Size = new Size(159, 60);
            btSend.TabIndex = 24;
            btSend.Text = "Send";
            btSend.TextColor = Color.FromArgb(252, 249, 248);
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += btSend_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(1146, 554);
            Controls.Add(btSend);
            Controls.Add(btScreenShare);
            Controls.Add(btCall);
            Controls.Add(btListen);
            Controls.Add(tbMessage);
            Controls.Add(lbStatus);
            Controls.Add(rtbRecv);
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