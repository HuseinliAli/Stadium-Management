namespace WinUI.Pages.Admin
{
    partial class UserDeleteModal
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
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            exit = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fullName = new Label();
            email = new Label();
            SuspendLayout();
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
            guna2Button2.Location = new Point(24, 146);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(127, 35);
            guna2Button2.TabIndex = 8;
            guna2Button2.Text = "Cancel";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Animated = true;
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.BorderRadius = 6;
            deleteBtn.CustomizableEdges = customizableEdges3;
            deleteBtn.DisabledState.BorderColor = Color.DarkGray;
            deleteBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteBtn.FillColor = Color.FromArgb(255, 205, 192);
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(162, 146);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deleteBtn.Size = new Size(127, 35);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.CustomizableEdges = customizableEdges5;
            exit.FillColor = Color.FromArgb(37, 37, 37);
            exit.IconColor = Color.White;
            exit.Location = new Point(256, -1);
            exit.Name = "exit";
            exit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exit.Size = new Size(45, 29);
            exit.TabIndex = 9;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 11;
            label1.Text = "Are you sure delete this user?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 12;
            label2.Text = "Full name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 94);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 13;
            label3.Text = "Email :";
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullName.ForeColor = Color.White;
            fullName.Location = new Point(95, 68);
            fullName.Name = "fullName";
            fullName.Size = new Size(0, 15);
            fullName.TabIndex = 14;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            email.ForeColor = Color.White;
            email.Location = new Point(95, 94);
            email.Name = "email";
            email.Size = new Size(0, 15);
            email.TabIndex = 15;
            // 
            // UserDeleteModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(301, 193);
            Controls.Add(email);
            Controls.Add(fullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(guna2Button2);
            Controls.Add(deleteBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDeleteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDeleteModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label fullName;
        private Label email;
    }
}