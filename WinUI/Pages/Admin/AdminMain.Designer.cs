namespace WinUI.Pages.Admin
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            naviPnl = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            roleLbl = new Label();
            userFullNameLbl = new Label();
            usersBtn = new Guna.UI2.WinForms.Guna2Button();
            homeBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            exit = new Guna.UI2.WinForms.Guna2ControlBox();
            usersPage1 = new UsersPage();
            homePage2 = new HomePage();
            naviPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // naviPnl
            // 
            naviPnl.Controls.Add(guna2CirclePictureBox1);
            naviPnl.Controls.Add(roleLbl);
            naviPnl.Controls.Add(userFullNameLbl);
            naviPnl.Controls.Add(usersBtn);
            naviPnl.Controls.Add(homeBtn);
            naviPnl.Dock = DockStyle.Left;
            naviPnl.Location = new Point(0, 0);
            naviPnl.Name = "naviPnl";
            naviPnl.Size = new Size(194, 768);
            naviPnl.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(26, 682);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(38, 38);
            guna2CirclePictureBox1.TabIndex = 5;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // roleLbl
            // 
            roleLbl.AutoSize = true;
            roleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            roleLbl.ForeColor = Color.FromArgb(150, 150, 150);
            roleLbl.Location = new Point(67, 701);
            roleLbl.Name = "roleLbl";
            roleLbl.Size = new Size(43, 15);
            roleLbl.TabIndex = 4;
            roleLbl.Text = "Admin";
            // 
            // userFullNameLbl
            // 
            userFullNameLbl.AutoSize = true;
            userFullNameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            userFullNameLbl.ForeColor = Color.White;
            userFullNameLbl.Location = new Point(66, 682);
            userFullNameLbl.Name = "userFullNameLbl";
            userFullNameLbl.Size = new Size(68, 19);
            userFullNameLbl.TabIndex = 3;
            userFullNameLbl.Text = "Full name";
            // 
            // usersBtn
            // 
            usersBtn.Animated = true;
            usersBtn.BorderRadius = 6;
            usersBtn.CustomizableEdges = customizableEdges2;
            usersBtn.DisabledState.BorderColor = Color.DarkGray;
            usersBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            usersBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            usersBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            usersBtn.FillColor = Color.Transparent;
            usersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            usersBtn.ForeColor = Color.White;
            usersBtn.Image = (Image)resources.GetObject("usersBtn.Image");
            usersBtn.ImageAlign = HorizontalAlignment.Left;
            usersBtn.ImageSize = new Size(32, 32);
            usersBtn.Location = new Point(14, 291);
            usersBtn.Name = "usersBtn";
            usersBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            usersBtn.Size = new Size(180, 45);
            usersBtn.TabIndex = 1;
            usersBtn.Text = "Users";
            usersBtn.TextAlign = HorizontalAlignment.Left;
            usersBtn.Click += usersBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Animated = true;
            homeBtn.BorderRadius = 6;
            homeBtn.CustomizableEdges = customizableEdges4;
            homeBtn.DisabledState.BorderColor = Color.DarkGray;
            homeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            homeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            homeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            homeBtn.FillColor = Color.Transparent;
            homeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            homeBtn.ForeColor = Color.White;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = HorizontalAlignment.Left;
            homeBtn.ImageSize = new Size(32, 32);
            homeBtn.Location = new Point(14, 240);
            homeBtn.Name = "homeBtn";
            homeBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            homeBtn.Size = new Size(180, 45);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.TextAlign = HorizontalAlignment.Left;
            homeBtn.Click += homeBtn_Click;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.BackColor = Color.FromArgb(20, 20, 20);
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges6;
            guna2ControlBox2.FillColor = Color.FromArgb(40, 40, 40);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(1231, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ControlBox2.Size = new Size(45, 29);
            guna2ControlBox2.TabIndex = 13;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.Animated = true;
            guna2ControlBox1.BackColor = Color.FromArgb(20, 20, 20);
            guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox1.CustomizableEdges = customizableEdges8;
            guna2ControlBox1.FillColor = Color.FromArgb(40, 40, 40);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1276, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 12;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.Animated = true;
            exit.BackColor = Color.FromArgb(20, 20, 20);
            exit.CustomizableEdges = customizableEdges10;
            exit.FillColor = Color.FromArgb(40, 40, 40);
            exit.IconColor = Color.White;
            exit.Location = new Point(1321, 0);
            exit.Name = "exit";
            exit.ShadowDecoration.CustomizableEdges = customizableEdges11;
            exit.Size = new Size(45, 29);
            exit.TabIndex = 11;
            // 
            // usersPage1
            // 
            usersPage1.BackColor = Color.FromArgb(37, 37, 37);
            usersPage1.Location = new Point(200, 38);
            usersPage1.Name = "usersPage1";
            usersPage1.Size = new Size(1169, 730);
            usersPage1.TabIndex = 14;
            // 
            // homePage2
            // 
            homePage2.BackColor = Color.FromArgb(37, 37, 37);
            homePage2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            homePage2.Location = new Point(201, 38);
            homePage2.Margin = new Padding(4);
            homePage2.Name = "homePage2";
            homePage2.Size = new Size(1169, 730);
            homePage2.TabIndex = 15;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(1366, 768);
            Controls.Add(homePage2);
            Controls.Add(usersPage1);
            Controls.Add(guna2ControlBox2);
            Controls.Add(guna2ControlBox1);
            Controls.Add(exit);
            Controls.Add(naviPnl);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
            Activated += AdminMain_Activated;
            Load += AdminMain_Load;
            naviPnl.ResumeLayout(false);
            naviPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel naviPnl;
        private Guna.UI2.WinForms.Guna2Button usersBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label roleLbl;
        private Label userFullNameLbl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private HomePage homePage1;
        private UsersPage usersPage1;
        private HomePage homePage2;
    }
}