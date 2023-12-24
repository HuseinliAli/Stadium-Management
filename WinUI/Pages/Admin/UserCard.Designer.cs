namespace WinUI.Pages.Admin
{
    partial class UserCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            emailLbl = new Label();
            lastNameLbl = new Label();
            countLbl = new Label();
            firtsNameLbl = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            roleBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(guna2Button2);
            guna2Panel1.Controls.Add(emailLbl);
            guna2Panel1.Controls.Add(lastNameLbl);
            guna2Panel1.Controls.Add(countLbl);
            guna2Panel1.Controls.Add(firtsNameLbl);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(roleBox);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(64, 64, 64);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(1060, 56);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 6;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(255, 225, 183);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(838, 11);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(90, 35);
            guna2Button2.TabIndex = 6;
            guna2Button2.Text = "Edit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.BackColor = Color.Transparent;
            emailLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLbl.ForeColor = Color.White;
            emailLbl.Location = new Point(453, 21);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(34, 13);
            emailLbl.TabIndex = 5;
            emailLbl.Text = "Email";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.BackColor = Color.Transparent;
            lastNameLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameLbl.ForeColor = Color.White;
            lastNameLbl.Location = new Point(267, 21);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(56, 13);
            lastNameLbl.TabIndex = 4;
            lastNameLbl.Text = "LastName";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.BackColor = Color.Transparent;
            countLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(23, 21);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(17, 13);
            countLbl.TabIndex = 3;
            countLbl.Text = "#.";
            // 
            // firtsNameLbl
            // 
            firtsNameLbl.AutoSize = true;
            firtsNameLbl.BackColor = Color.Transparent;
            firtsNameLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            firtsNameLbl.ForeColor = Color.White;
            firtsNameLbl.Location = new Point(72, 21);
            firtsNameLbl.Name = "firtsNameLbl";
            firtsNameLbl.Size = new Size(58, 13);
            firtsNameLbl.TabIndex = 2;
            firtsNameLbl.Text = "FirstName";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 205, 192);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(944, 11);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(90, 35);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Delete";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // roleBox
            // 
            roleBox.BackColor = Color.Transparent;
            roleBox.BorderRadius = 6;
            roleBox.CustomizableEdges = customizableEdges5;
            roleBox.DrawMode = DrawMode.OwnerDrawFixed;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.FillColor = Color.FromArgb(64, 64, 64);
            roleBox.FocusedColor = Color.FromArgb(94, 148, 255);
            roleBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            roleBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            roleBox.ForeColor = Color.White;
            roleBox.ItemHeight = 29;
            roleBox.Location = new Point(667, 11);
            roleBox.Name = "roleBox";
            roleBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            roleBox.Size = new Size(140, 35);
            roleBox.TabIndex = 0;
            // 
            // UserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            Controls.Add(guna2Panel1);
            Name = "UserCard";
            Size = new Size(1060, 56);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox roleBox;
        private Label firtsNameLbl;
        private Label countLbl;
        private Label emailLbl;
        private Label lastNameLbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
