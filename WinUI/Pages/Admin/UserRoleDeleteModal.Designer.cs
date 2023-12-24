namespace WinUI.Pages.Admin
{
    partial class UserRoleDeleteModal
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            exit = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameLbl = new Label();
            roleNameLbl = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.CustomizableEdges = customizableEdges1;
            exit.FillColor = Color.FromArgb(37, 37, 37);
            exit.IconColor = Color.White;
            exit.Location = new Point(256, -4);
            exit.Name = "exit";
            exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            exit.Size = new Size(45, 29);
            exit.TabIndex = 10;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 6;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(255, 225, 183);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(24, 146);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(127, 35);
            guna2Button2.TabIndex = 12;
            guna2Button2.Text = "Cancel";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Animated = true;
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.BorderRadius = 6;
            deleteBtn.CustomizableEdges = customizableEdges5;
            deleteBtn.DisabledState.BorderColor = Color.DarkGray;
            deleteBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteBtn.FillColor = Color.FromArgb(255, 205, 192);
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(162, 146);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            deleteBtn.Size = new Size(127, 35);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 13;
            label1.Text = "Are you sure delete role from the user?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "User :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 87);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 15;
            label3.Text = "Role will deleted :";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameLbl.ForeColor = Color.White;
            userNameLbl.Location = new Point(76, 63);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(0, 15);
            userNameLbl.TabIndex = 16;
            // 
            // roleNameLbl
            // 
            roleNameLbl.AutoSize = true;
            roleNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            roleNameLbl.ForeColor = Color.White;
            roleNameLbl.Location = new Point(150, 89);
            roleNameLbl.Name = "roleNameLbl";
            roleNameLbl.Size = new Size(0, 15);
            roleNameLbl.TabIndex = 17;
            // 
            // UserRoleDeleteModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(301, 193);
            Controls.Add(roleNameLbl);
            Controls.Add(userNameLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(deleteBtn);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserRoleDeleteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRoleDeleteModal";
            FormClosing += UserRoleDeleteModal_FormClosing;
            FormClosed += UserRoleDeleteModal_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label userNameLbl;
        private Label roleNameLbl;
    }
}