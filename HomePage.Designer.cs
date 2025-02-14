namespace Home_Appliances_Rental_System
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_user_login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_admin_login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(131, 83);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(679, 259);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.Animated = true;
            this.btn_register.AutoRoundedCorners = true;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BorderRadius = 36;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_register.IndicateFocus = true;
            this.btn_register.Location = new System.Drawing.Point(27, 375);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(195, 75);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseTransparentBackground = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_user_login
            // 
            this.btn_user_login.Animated = true;
            this.btn_user_login.AutoRoundedCorners = true;
            this.btn_user_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_user_login.BorderRadius = 36;
            this.btn_user_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_user_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_user_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_user_login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_user_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_user_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_user_login.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_user_login.IndicateFocus = true;
            this.btn_user_login.Location = new System.Drawing.Point(347, 375);
            this.btn_user_login.Name = "btn_user_login";
            this.btn_user_login.Size = new System.Drawing.Size(200, 75);
            this.btn_user_login.TabIndex = 3;
            this.btn_user_login.Text = "User Login";
            this.btn_user_login.UseTransparentBackground = true;
            this.btn_user_login.Click += new System.EventHandler(this.btn_user_login_Click);
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Animated = true;
            this.btn_admin_login.AutoRoundedCorners = true;
            this.btn_admin_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_admin_login.BorderRadius = 36;
            this.btn_admin_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_admin_login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_admin_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_admin_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_admin_login.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_admin_login.IndicateFocus = true;
            this.btn_admin_login.Location = new System.Drawing.Point(656, 375);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(200, 75);
            this.btn_admin_login.TabIndex = 4;
            this.btn_admin_login.Text = "Admin Login";
            this.btn_admin_login.UseTransparentBackground = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(251, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(559, 50);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Home Appliances Rental";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(944, 480);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.btn_user_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_register;
        private Guna.UI2.WinForms.Guna2GradientButton btn_user_login;
        private Guna.UI2.WinForms.Guna2GradientButton btn_admin_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

