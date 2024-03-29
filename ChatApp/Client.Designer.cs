﻿namespace ChatApp
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
            btSend = new Addon_Custom_Button();
            btScreenShare = new Addon_Custom_Button();
            btCall = new Addon_Custom_Button();
            btConnect = new Addon_Custom_Button();
            rtbSend = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(11, 585);
            tbMessage.Margin = new Padding(2);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(912, 31);
            tbMessage.TabIndex = 13;
            tbMessage.KeyDown += tbMessage_KeyDown;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.FromArgb(73, 103, 39);
            lbStatus.Location = new Point(25, 45);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 25);
            lbStatus.TabIndex = 12;
            // 
            // rtbRecv
            // 
            rtbRecv.BorderStyle = BorderStyle.None;
            rtbRecv.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rtbRecv.Location = new Point(14, 106);
            rtbRecv.Margin = new Padding(2);
            rtbRecv.Name = "rtbRecv";
            rtbRecv.Size = new Size(556, 441);
            rtbRecv.TabIndex = 10;
            rtbRecv.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(366, 42);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 19;
            textBox1.Text = "127.0.0.1";
            // 
            // btSend
            // 
            btSend.BackColor = Color.FromArgb(73, 103, 39);
            btSend.BackgroundColor = Color.FromArgb(73, 103, 39);
            btSend.BorderColor = Color.PaleVioletRed;
            btSend.BorderRadius = 30;
            btSend.BorderSize = 0;
            btSend.FlatAppearance.BorderSize = 0;
            btSend.FlatStyle = FlatStyle.Flat;
            btSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.ForeColor = Color.FromArgb(252, 249, 248);
            btSend.Location = new Point(944, 556);
            btSend.Name = "btSend";
            btSend.Size = new Size(159, 60);
            btSend.TabIndex = 27;
            btSend.Text = "Send";
            btSend.TextColor = Color.FromArgb(252, 249, 248);
            btSend.UseVisualStyleBackColor = false;
            btSend.Click += bt_Send_Click;
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
            btScreenShare.ForeColor = Color.FromArgb(73, 103, 39);
            btScreenShare.Location = new Point(626, 27);
            btScreenShare.Name = "btScreenShare";
            btScreenShare.Size = new Size(153, 60);
            btScreenShare.TabIndex = 26;
            btScreenShare.Text = "Screen share";
            btScreenShare.TextColor = Color.FromArgb(73, 103, 39);
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
            btCall.ForeColor = Color.FromArgb(73, 103, 39);
            btCall.Location = new Point(785, 27);
            btCall.Name = "btCall";
            btCall.Size = new Size(153, 60);
            btCall.TabIndex = 25;
            btCall.Text = "Call";
            btCall.TextColor = Color.FromArgb(73, 103, 39);
            btCall.UseVisualStyleBackColor = false;
            btCall.Click += btCall_Click;
            // 
            // btConnect
            // 
            btConnect.BackColor = Color.FromArgb(73, 103, 39);
            btConnect.BackgroundColor = Color.FromArgb(73, 103, 39);
            btConnect.BorderColor = Color.PaleVioletRed;
            btConnect.BorderRadius = 30;
            btConnect.BorderSize = 0;
            btConnect.FlatAppearance.BorderSize = 0;
            btConnect.FlatStyle = FlatStyle.Flat;
            btConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btConnect.ForeColor = Color.FromArgb(252, 249, 248);
            btConnect.Location = new Point(944, 27);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(159, 60);
            btConnect.TabIndex = 24;
            btConnect.Text = "Connect";
            btConnect.TextColor = Color.FromArgb(252, 249, 248);
            btConnect.UseVisualStyleBackColor = false;
            btConnect.Click += btConnect_Click;
            // 
            // rtbSend
            // 
            rtbSend.BorderStyle = BorderStyle.None;
            rtbSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rtbSend.Location = new Point(574, 110);
            rtbSend.Margin = new Padding(2);
            rtbSend.Name = "rtbSend";
            rtbSend.Size = new Size(550, 441);
            rtbSend.TabIndex = 28;
            rtbSend.Text = "";
            rtbSend.TextChanged += richTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 103, 39);
            label2.Location = new Point(195, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 37;
            label2.Text = "Server IP Address";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(1126, 631);
            Controls.Add(label2);
            Controls.Add(rtbSend);
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
        private Addon_Custom_Button btSend;
        private Addon_Custom_Button btScreenShare;
        private Addon_Custom_Button btCall;
        private Addon_Custom_Button btConnect;
        private RichTextBox rtbSend;
        private Label label2;
    }
}