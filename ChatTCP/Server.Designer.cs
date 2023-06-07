namespace ChatTCP
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
            this.bt_Listen = new System.Windows.Forms.Button();
            this.rtb_MessageServer = new System.Windows.Forms.RichTextBox();
            this.bt_Call = new System.Windows.Forms.Button();
            this.ptb_Video = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Listen
            // 
            this.bt_Listen.Location = new System.Drawing.Point(12, 12);
            this.bt_Listen.Name = "bt_Listen";
            this.bt_Listen.Size = new System.Drawing.Size(150, 42);
            this.bt_Listen.TabIndex = 0;
            this.bt_Listen.Text = "Listen";
            this.bt_Listen.UseVisualStyleBackColor = true;
            this.bt_Listen.Click += new System.EventHandler(this.bt_Listen_Click);
            // 
            // rtb_MessageServer
            // 
            this.rtb_MessageServer.Location = new System.Drawing.Point(733, 22);
            this.rtb_MessageServer.Name = "rtb_MessageServer";
            this.rtb_MessageServer.Size = new System.Drawing.Size(401, 508);
            this.rtb_MessageServer.TabIndex = 1;
            this.rtb_MessageServer.Text = "";
            // 
            // bt_Call
            // 
            this.bt_Call.Location = new System.Drawing.Point(12, 60);
            this.bt_Call.Name = "bt_Call";
            this.bt_Call.Size = new System.Drawing.Size(150, 43);
            this.bt_Call.TabIndex = 2;
            this.bt_Call.Text = "Call";
            this.bt_Call.UseVisualStyleBackColor = true;
            this.bt_Call.Click += new System.EventHandler(this.bt_Call_ClickAsync);
            // 
            // ptb_Video
            // 
            this.ptb_Video.Location = new System.Drawing.Point(13, 114);
            this.ptb_Video.Name = "ptb_Video";
            this.ptb_Video.Size = new System.Drawing.Size(714, 415);
            this.ptb_Video.TabIndex = 3;
            this.ptb_Video.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 542);
            this.Controls.Add(this.ptb_Video);
            this.Controls.Add(this.bt_Call);
            this.Controls.Add(this.rtb_MessageServer);
            this.Controls.Add(this.bt_Listen);
            this.Name = "Server";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Listen;
        private System.Windows.Forms.RichTextBox rtb_MessageServer;
        private System.Windows.Forms.Button bt_Call;
        private System.Windows.Forms.PictureBox ptb_Video;
    }
}