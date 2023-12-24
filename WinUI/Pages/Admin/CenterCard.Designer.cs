namespace WinUI.Pages.Admin
{
    partial class CenterCard
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
            viewLnk = new LinkLabel();
            stadiumCountLbl = new Label();
            createdByLbl = new Label();
            phoneLbl = new Label();
            emailLbl = new Label();
            nameTxt = new RichTextBox();
            countLbl = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(viewLnk);
            guna2Panel1.Controls.Add(stadiumCountLbl);
            guna2Panel1.Controls.Add(createdByLbl);
            guna2Panel1.Controls.Add(phoneLbl);
            guna2Panel1.Controls.Add(emailLbl);
            guna2Panel1.Controls.Add(nameTxt);
            guna2Panel1.Controls.Add(countLbl);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.FillColor = Color.FromArgb(64, 64, 64);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1060, 56);
            guna2Panel1.TabIndex = 0;
            // 
            // viewLnk
            // 
            viewLnk.AutoSize = true;
            viewLnk.LinkColor = Color.White;
            viewLnk.Location = new Point(996, 19);
            viewLnk.Name = "viewLnk";
            viewLnk.Size = new Size(32, 15);
            viewLnk.TabIndex = 7;
            viewLnk.TabStop = true;
            viewLnk.Text = "View";
            // 
            // stadiumCountLbl
            // 
            stadiumCountLbl.AutoSize = true;
            stadiumCountLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            stadiumCountLbl.ForeColor = Color.White;
            stadiumCountLbl.Location = new Point(861, 21);
            stadiumCountLbl.Name = "stadiumCountLbl";
            stadiumCountLbl.Size = new Size(82, 13);
            stadiumCountLbl.TabIndex = 6;
            stadiumCountLbl.Text = "Stadium count";
            // 
            // createdByLbl
            // 
            createdByLbl.AutoSize = true;
            createdByLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            createdByLbl.ForeColor = Color.White;
            createdByLbl.Location = new Point(678, 21);
            createdByLbl.Name = "createdByLbl";
            createdByLbl.Size = new Size(62, 13);
            createdByLbl.TabIndex = 5;
            createdByLbl.Text = "Created by";
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneLbl.ForeColor = Color.White;
            phoneLbl.Location = new Point(458, 21);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(40, 13);
            phoneLbl.TabIndex = 4;
            phoneLbl.Text = "Phone";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLbl.ForeColor = Color.White;
            emailLbl.Location = new Point(241, 21);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(34, 13);
            emailLbl.TabIndex = 3;
            emailLbl.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.FromArgb(64, 64, 64);
            nameTxt.BorderStyle = BorderStyle.None;
            nameTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTxt.ForeColor = Color.White;
            nameTxt.Location = new Point(64, 3);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(147, 50);
            nameTxt.TabIndex = 2;
            nameTxt.Text = "Name";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(25, 21);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(16, 13);
            countLbl.TabIndex = 1;
            countLbl.Text = "X.";
            // 
            // CenterCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            Controls.Add(guna2Panel1);
            Name = "CenterCard";
            Size = new Size(1060, 56);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private RichTextBox nameTxt;
        private Label countLbl;
        private Label stadiumCountLbl;
        private Label createdByLbl;
        private Label phoneLbl;
        private Label emailLbl;
        private LinkLabel viewLnk;
    }
}
