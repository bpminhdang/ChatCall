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
            panel1 = new Panel();
            addon_Custom_Button1 = new Addon_Custom_Button();
            panel3 = new Panel();
            addon_Custom_Button3 = new Addon_Custom_Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btServer
            // 
            btServer.BackColor = Color.FromArgb(185, 0, 99);
            btServer.BackgroundColor = Color.FromArgb(185, 0, 99);
            btServer.BorderColor = Color.PaleVioletRed;
            btServer.BorderRadius = 40;
            btServer.BorderSize = 0;
            btServer.FlatAppearance.BorderSize = 0;
            btServer.FlatStyle = FlatStyle.Flat;
            btServer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btServer.ForeColor = Color.FromArgb(252, 249, 248);
            btServer.Location = new Point(551, 417);
            btServer.Margin = new Padding(2);
            btServer.Name = "btServer";
            btServer.Size = new Size(246, 84);
            btServer.TabIndex = 9;
            btServer.Text = "Server";
            btServer.TextColor = Color.FromArgb(252, 249, 248);
            btServer.UseVisualStyleBackColor = false;
            btServer.Click += btServer_Click;
            // 
            // btClient
            // 
            btClient.BackColor = Color.White;
            btClient.BackgroundColor = Color.White;
            btClient.BorderColor = Color.FromArgb(141, 126, 129);
            btClient.BorderRadius = 40;
            btClient.BorderSize = 1;
            btClient.FlatAppearance.BorderSize = 0;
            btClient.FlatStyle = FlatStyle.Flat;
            btClient.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btClient.ForeColor = Color.FromArgb(185, 0, 99);
            btClient.Location = new Point(551, 514);
            btClient.Margin = new Padding(2);
            btClient.Name = "btClient";
            btClient.Size = new Size(246, 84);
            btClient.TabIndex = 21;
            btClient.Text = "Client";
            btClient.TextColor = Color.FromArgb(185, 0, 99);
            btClient.UseVisualStyleBackColor = false;
            btClient.Click += btClient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 66);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 410);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(addon_Custom_Button1);
            panel1.Location = new Point(26, 553);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 48);
            panel1.TabIndex = 23;
            // 
            // addon_Custom_Button1
            // 
            addon_Custom_Button1.BackColor = Color.White;
            addon_Custom_Button1.BackgroundColor = Color.White;
            addon_Custom_Button1.BorderColor = Color.FromArgb(141, 126, 129);
            addon_Custom_Button1.BorderRadius = 20;
            addon_Custom_Button1.BorderSize = 1;
            addon_Custom_Button1.FlatAppearance.BorderSize = 0;
            addon_Custom_Button1.FlatStyle = FlatStyle.Flat;
            addon_Custom_Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addon_Custom_Button1.ForeColor = Color.FromArgb(185, 0, 99);
            addon_Custom_Button1.Location = new Point(2, 2);
            addon_Custom_Button1.Margin = new Padding(2);
            addon_Custom_Button1.Name = "addon_Custom_Button1";
            addon_Custom_Button1.Size = new Size(269, 43);
            addon_Custom_Button1.TabIndex = 22;
            addon_Custom_Button1.Text = "HELP";
            addon_Custom_Button1.TextColor = Color.FromArgb(185, 0, 99);
            addon_Custom_Button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(addon_Custom_Button3);
            panel3.Location = new Point(276, 553);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 48);
            panel3.TabIndex = 24;
            // 
            // addon_Custom_Button3
            // 
            addon_Custom_Button3.BackColor = Color.White;
            addon_Custom_Button3.BackgroundColor = Color.White;
            addon_Custom_Button3.BorderColor = Color.FromArgb(141, 126, 129);
            addon_Custom_Button3.BorderRadius = 20;
            addon_Custom_Button3.BorderSize = 1;
            addon_Custom_Button3.FlatAppearance.BorderSize = 0;
            addon_Custom_Button3.FlatStyle = FlatStyle.Flat;
            addon_Custom_Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addon_Custom_Button3.ForeColor = Color.FromArgb(185, 0, 99);
            addon_Custom_Button3.Location = new Point(-24, 2);
            addon_Custom_Button3.Margin = new Padding(2);
            addon_Custom_Button3.Name = "addon_Custom_Button3";
            addon_Custom_Button3.Size = new Size(268, 43);
            addon_Custom_Button3.TabIndex = 22;
            addon_Custom_Button3.Text = "ABOUT";
            addon_Custom_Button3.TextColor = Color.FromArgb(185, 0, 99);
            addon_Custom_Button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 126, 129);
            panel2.Location = new Point(271, 554);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 43);
            panel2.TabIndex = 25;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(827, 631);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btClient);
            Controls.Add(btServer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Menu";
            Text = "ChatChat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Addon_Custom_Button btServer;
        private Addon_Custom_Button btClient;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Addon_Custom_Button addon_Custom_Button1;
        private Panel panel3;
        private Addon_Custom_Button addon_Custom_Button3;
        private Panel panel2;
    }
}