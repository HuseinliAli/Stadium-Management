namespace WinUI.Pages.Vendor
{
    partial class StadiumCard
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
            evening = new Label();
            afternoon = new Label();
            morningLbl = new Label();
            nameLbl = new Label();
            countLbl = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 12;
            guna2Panel1.Controls.Add(evening);
            guna2Panel1.Controls.Add(afternoon);
            guna2Panel1.Controls.Add(morningLbl);
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
            // 
            // evening
            // 
            evening.AutoSize = true;
            evening.BackColor = Color.Transparent;
            evening.ForeColor = Color.White;
            evening.Location = new Point(409, 18);
            evening.Name = "evening";
            evening.Size = new Size(49, 15);
            evening.TabIndex = 7;
            evening.Text = "Evening";
            // 
            // afternoon
            // 
            afternoon.AutoSize = true;
            afternoon.BackColor = Color.Transparent;
            afternoon.ForeColor = Color.White;
            afternoon.Location = new Point(342, 18);
            afternoon.Name = "afternoon";
            afternoon.Size = new Size(61, 15);
            afternoon.TabIndex = 6;
            afternoon.Text = "Afternoon";
            // 
            // morningLbl
            // 
            morningLbl.AutoSize = true;
            morningLbl.BackColor = Color.Transparent;
            morningLbl.ForeColor = Color.White;
            morningLbl.Location = new Point(277, 18);
            morningLbl.Name = "morningLbl";
            morningLbl.Size = new Size(53, 15);
            morningLbl.TabIndex = 5;
            morningLbl.Text = "Morning";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.BackColor = Color.Transparent;
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(89, 18);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(60, 15);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "HallName";
            nameLbl.Click += nameLbl_Click;
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.BackColor = Color.Transparent;
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(20, 18);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(14, 15);
            countLbl.TabIndex = 3;
            countLbl.Text = "#";
            // 
            // StadiumCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            Controls.Add(guna2Panel1);
            Name = "StadiumCard";
            Size = new Size(475, 50);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label evening;
        private Label afternoon;
        private Label morningLbl;
        private Label nameLbl;
        private Label countLbl;
    }
}
