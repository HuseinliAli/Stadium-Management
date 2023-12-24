namespace WinUI.Pages.Admin
{
    partial class UsersPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            userLytPnl = new FlowLayoutPanel();
            claimsCombobx = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            refresh = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.BorderRadius = 22;
            searchTxt.CustomizableEdges = customizableEdges1;
            searchTxt.DefaultText = "";
            searchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTxt.FillColor = Color.FromArgb(64, 64, 64);
            searchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTxt.IconLeft = (Image)resources.GetObject("searchTxt.IconLeft");
            searchTxt.IconLeftOffset = new Point(10, 0);
            searchTxt.IconLeftSize = new Size(24, 24);
            searchTxt.Location = new Point(50, 45);
            searchTxt.Name = "searchTxt";
            searchTxt.PasswordChar = '\0';
            searchTxt.PlaceholderText = "Search for user by email";
            searchTxt.SelectedText = "";
            searchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchTxt.Size = new Size(366, 44);
            searchTxt.TabIndex = 1;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // userLytPnl
            // 
            userLytPnl.Location = new Point(50, 118);
            userLytPnl.Name = "userLytPnl";
            userLytPnl.Size = new Size(1054, 580);
            userLytPnl.TabIndex = 2;
            // 
            // claimsCombobx
            // 
            claimsCombobx.BackColor = Color.Transparent;
            claimsCombobx.CustomizableEdges = customizableEdges3;
            claimsCombobx.DrawMode = DrawMode.OwnerDrawFixed;
            claimsCombobx.DropDownStyle = ComboBoxStyle.DropDownList;
            claimsCombobx.FillColor = Color.FromArgb(37, 37, 37);
            claimsCombobx.FocusedColor = Color.FromArgb(94, 148, 255);
            claimsCombobx.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            claimsCombobx.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            claimsCombobx.ForeColor = Color.White;
            claimsCombobx.ItemHeight = 30;
            claimsCombobx.Location = new Point(600, 53);
            claimsCombobx.Name = "claimsCombobx";
            claimsCombobx.ShadowDecoration.CustomizableEdges = customizableEdges4;
            claimsCombobx.Size = new Size(140, 36);
            claimsCombobx.TabIndex = 3;
            claimsCombobx.SelectedIndexChanged += claimsCombobx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(466, 53);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 4;
            label1.Text = "Filter by role";
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 4;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(182, 209, 255);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.ImageSize = new Size(24, 24);
            guna2Button2.Location = new Point(959, 45);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(145, 44);
            guna2Button2.TabIndex = 8;
            guna2Button2.Text = "Create new user";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // refresh
            // 
            refresh.Animated = true;
            refresh.BackColor = Color.Transparent;
            refresh.BorderRadius = 4;
            refresh.CustomizableEdges = customizableEdges7;
            refresh.DisabledState.BorderColor = Color.DarkGray;
            refresh.DisabledState.CustomBorderColor = Color.DarkGray;
            refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            refresh.FillColor = Color.FromArgb(182, 209, 255);
            refresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refresh.ForeColor = Color.Black;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.ImageSize = new Size(22, 22);
            refresh.Location = new Point(889, 45);
            refresh.Name = "refresh";
            refresh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            refresh.Size = new Size(44, 44);
            refresh.TabIndex = 9;
            refresh.Click += refresh_Click;
            // 
            // UsersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            Controls.Add(refresh);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(claimsCombobx);
            Controls.Add(userLytPnl);
            Controls.Add(searchTxt);
            Name = "UsersPage";
            Size = new Size(1169, 730);
            Load += UsersPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private FlowLayoutPanel userLytPnl;
        private Guna.UI2.WinForms.Guna2ComboBox claimsCombobx;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button refresh;
    }
}
