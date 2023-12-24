namespace WinUI.Pages.Admin
{
    partial class UserRoleCard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            roleNameLbl = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            countLbl = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 4;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 205, 192);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.ImageSize = new Size(24, 24);
            guna2Button1.Location = new Point(289, 8);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(145, 36);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Delete from the role";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // roleNameLbl
            // 
            roleNameLbl.AutoSize = true;
            roleNameLbl.BackColor = Color.Transparent;
            roleNameLbl.ForeColor = Color.White;
            roleNameLbl.Location = new Point(96, 18);
            roleNameLbl.Name = "roleNameLbl";
            roleNameLbl.Size = new Size(63, 15);
            roleNameLbl.TabIndex = 8;
            roleNameLbl.Text = "Role name";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(37, 37, 37);
            guna2Panel1.BorderRadius = 6;
            guna2Panel1.Controls.Add(countLbl);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(roleNameLbl);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(64, 64, 64);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(460, 52);
            guna2Panel1.TabIndex = 9;
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.BackColor = Color.Transparent;
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(27, 18);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(14, 15);
            countLbl.TabIndex = 9;
            countLbl.Text = "#";
            // 
            // UserRoleCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            Controls.Add(guna2Panel1);
            Name = "UserRoleCard";
            Size = new Size(460, 52);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label roleNameLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label countLbl;
    }
}
