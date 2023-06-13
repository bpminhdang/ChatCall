namespace ChatApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btServer = new Addon_Custom_Button();
            btClient = new Addon_Custom_Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btServer
            // 
            btServer.BackColor = Color.FromArgb(255, 143, 7);
            btServer.BackgroundColor = Color.FromArgb(255, 143, 7);
            btServer.BorderColor = Color.PaleVioletRed;
            btServer.BorderRadius = 30;
            btServer.BorderSize = 0;
            btServer.FlatAppearance.BorderSize = 0;
            btServer.FlatStyle = FlatStyle.Flat;
            btServer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btServer.ForeColor = Color.FromArgb(252, 249, 248);
            btServer.Location = new Point(102, 228);
            btServer.Margin = new Padding(2);
            btServer.Name = "btServer";
            btServer.Size = new Size(127, 54);
            btServer.TabIndex = 9;
            btServer.Text = "Server";
            btServer.TextColor = Color.FromArgb(252, 249, 248);
            btServer.UseVisualStyleBackColor = false;
            btServer.Click += btServer_Click;
            // 
            // btClient
            // 
            btClient.BackColor = Color.FromArgb(255, 60, 76);
            btClient.BackgroundColor = Color.FromArgb(255, 60, 76);
            btClient.BorderColor = Color.PaleVioletRed;
            btClient.BorderRadius = 30;
            btClient.BorderSize = 0;
            btClient.FlatAppearance.BorderSize = 0;
            btClient.FlatStyle = FlatStyle.Flat;
            btClient.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btClient.ForeColor = Color.FromArgb(252, 249, 248);
            btClient.Location = new Point(102, 288);
            btClient.Margin = new Padding(2);
            btClient.Name = "btClient";
            btClient.Size = new Size(127, 54);
            btClient.TabIndex = 21;
            btClient.Text = "Client";
            btClient.TextColor = Color.FromArgb(252, 249, 248);
            btClient.UseVisualStyleBackColor = false;
            btClient.Click += btClient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 252, 246);
            ClientSize = new Size(352, 366);
            Controls.Add(pictureBox1);
            Controls.Add(btClient);
            Controls.Add(btServer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "ChatChat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Addon_Custom_Button btServer;
        private Addon_Custom_Button btClient;
        private PictureBox pictureBox1;
    }
}