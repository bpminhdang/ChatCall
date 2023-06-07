namespace ChatTCP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.rtb_Send = new System.Windows.Forms.RichTextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 352);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(3, 373);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(144, 41);
            this.bt_Connect.TabIndex = 1;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(163, 373);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(144, 41);
            this.bt_Disconnect.TabIndex = 2;
            this.bt_Disconnect.Text = "Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // rtb_Send
            // 
            this.rtb_Send.Location = new System.Drawing.Point(616, 3);
            this.rtb_Send.Name = "rtb_Send";
            this.rtb_Send.Size = new System.Drawing.Size(379, 440);
            this.rtb_Send.TabIndex = 3;
            this.rtb_Send.Text = "";
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(851, 459);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(144, 41);
            this.bt_Send.TabIndex = 4;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 512);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.rtb_Send);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.RichTextBox rtb_Send;
        private System.Windows.Forms.Button bt_Send;
    }
}

