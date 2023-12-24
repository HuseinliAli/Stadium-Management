namespace WinUI.Pages.Admin
{
    partial class UserEditModal
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            rolesLytPnl = new FlowLayoutPanel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            infoLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            emailLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            roleBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // rolesLytPnl
            // 
            rolesLytPnl.AutoScroll = true;
            rolesLytPnl.Location = new Point(12, 53);
            rolesLytPnl.Name = "rolesLytPnl";
            rolesLytPnl.Size = new Size(480, 204);
            rolesLytPnl.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(37, 37, 37);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(460, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 1;
            // 
            // infoLbl
            // 
            infoLbl.BackColor = Color.Transparent;
            infoLbl.ForeColor = Color.White;
            infoLbl.Location = new Point(12, 21);
            infoLbl.Name = "infoLbl";
            infoLbl.Size = new Size(53, 17);
            infoLbl.TabIndex = 2;
            infoLbl.Text = "Role(s) of ";
            // 
            // emailLabel
            // 
            emailLabel.BackColor = Color.Transparent;
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(71, 21);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(115, 17);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "example@gmail.com";
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.FromArgb(224, 254, 207);
            guna2Button2.BorderRadius = 6;
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(37, 37, 37);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(224, 254, 207);
            guna2Button2.Location = new Point(402, 263);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(90, 35);
            guna2Button2.TabIndex = 7;
            guna2Button2.Text = "Add role";
            guna2Button2.Click += guna2Button2_Click;
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
            roleBox.Location = new Point(12, 263);
            roleBox.Name = "roleBox";
            roleBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            roleBox.Size = new Size(384, 35);
            roleBox.TabIndex = 10;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.FromArgb(224, 254, 207);
            guna2Button1.BorderRadius = 6;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(224, 254, 207);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.FromArgb(37, 37, 37);
            guna2Button1.Location = new Point(12, 314);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(480, 35);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Save changes";
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // UserEditModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(504, 365);
            Controls.Add(guna2Button1);
            Controls.Add(roleBox);
            Controls.Add(guna2Button2);
            Controls.Add(emailLabel);
            Controls.Add(infoLbl);
            Controls.Add(guna2ControlBox1);
            Controls.Add(rolesLytPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserEditModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserEditModal";
            FormClosing += UserEditModal_FormClosing;
            Load += UserEditModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel rolesLytPnl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel infoLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox roleBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}