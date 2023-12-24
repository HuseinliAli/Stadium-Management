namespace WinUI.Pages.Vendor
{
    partial class CenterVendorCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            emailLbl = new Label();
            nameLbl = new Label();
            countLbl = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(emailLbl);
            guna2Panel1.Controls.Add(nameLbl);
            guna2Panel1.Controls.Add(countLbl);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(37, 37, 37);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(475, 50);
            guna2Panel1.TabIndex = 0;
//            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.BackColor = Color.Transparent;
            emailLbl.ForeColor = Color.White;
            emailLbl.Location = new Point(281, 16);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(36, 15);
            emailLbl.TabIndex = 2;
            emailLbl.Text = "Email";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.BackColor = Color.Transparent;
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(86, 16);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(39, 15);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "Name";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.BackColor = Color.Transparent;
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(17, 16);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(14, 15);
            countLbl.TabIndex = 0;
            countLbl.Text = "#";
            // 
            // CenterCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            Controls.Add(guna2Panel1);
            Name = "CenterCard";
            Size = new Size(475, 50);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label nameLbl;
        private Label countLbl;
        private Label emailLbl;
    }
}
