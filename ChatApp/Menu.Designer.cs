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
            btServer.BackColor = Color.FromArgb(185, 0, 99);
            btServer.BackgroundColor = Color.FromArgb(185, 0, 99);
            btServer.BorderColor = Color.PaleVioletRed;
            btServer.BorderRadius = 40;
            btServer.BorderSize = 0;
            btServer.FlatAppearance.BorderSize = 0;
            btServer.FlatStyle = FlatStyle.Flat;
            btServer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btServer.ForeColor = Color.FromArgb(252, 249, 248);
            btServer.Location = new Point(485, 55);
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
            btClient.Location = new Point(485, 152);
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
            pictureBox1.Location = new Point(32, 55);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 410);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 255);
            ClientSize = new Size(766, 498);
            Controls.Add(pictureBox1);
            Controls.Add(btClient);
            Controls.Add(btServer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Menu";
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