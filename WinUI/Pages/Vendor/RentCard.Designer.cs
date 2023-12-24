namespace WinUI.Pages.Vendor
{
    partial class RentCard
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
            startFinishLbl = new Label();
            countLbl = new Label();
            stadiumLbl = new Label();
            userLbl = new Label();
            price = new Label();
            rentedAtLbl = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // startFinishLbl
            // 
            startFinishLbl.AutoSize = true;
            startFinishLbl.BackColor = Color.Transparent;
            startFinishLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startFinishLbl.ForeColor = Color.White;
            startFinishLbl.Location = new Point(76, 19);
            startFinishLbl.Name = "startFinishLbl";
            startFinishLbl.Size = new Size(79, 19);
            startFinishLbl.TabIndex = 0;
            startFinishLbl.Text = "Start-Finish";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.BackColor = Color.Transparent;
            countLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            countLbl.ForeColor = Color.White;
            countLbl.Location = new Point(24, 19);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(17, 19);
            countLbl.TabIndex = 1;
            countLbl.Text = "#";
            // 
            // stadiumLbl
            // 
            stadiumLbl.AutoSize = true;
            stadiumLbl.BackColor = Color.Transparent;
            stadiumLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            stadiumLbl.ForeColor = Color.White;
            stadiumLbl.Location = new Point(278, 19);
            stadiumLbl.Name = "stadiumLbl";
            stadiumLbl.Size = new Size(59, 19);
            stadiumLbl.TabIndex = 2;
            stadiumLbl.Text = "Stadium";
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.BackColor = Color.Transparent;
            userLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            userLbl.ForeColor = Color.White;
            userLbl.Location = new Point(452, 19);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(37, 19);
            userLbl.TabIndex = 3;
            userLbl.Text = "User";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            price.ForeColor = Color.White;
            price.Location = new Point(618, 19);
            price.Name = "price";
            price.Size = new Size(132, 19);
            price.TabIndex = 4;
            price.Text = "Price-Total(With tax)";
            // 
            // rentedAtLbl
            // 
            rentedAtLbl.AutoSize = true;
            rentedAtLbl.BackColor = Color.Transparent;
            rentedAtLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentedAtLbl.ForeColor = Color.White;
            rentedAtLbl.Location = new Point(854, 19);
            rentedAtLbl.Name = "rentedAtLbl";
            rentedAtLbl.Size = new Size(68, 19);
            rentedAtLbl.TabIndex = 5;
            rentedAtLbl.Text = "Rented at";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(120, 120, 120);
            guna2Panel1.BorderRadius = 12;
            guna2Panel1.Controls.Add(rentedAtLbl);
            guna2Panel1.Controls.Add(price);
            guna2Panel1.Controls.Add(userLbl);
            guna2Panel1.Controls.Add(stadiumLbl);
            guna2Panel1.Controls.Add(countLbl);
            guna2Panel1.Controls.Add(startFinishLbl);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(37, 37, 37);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(999, 54);
            guna2Panel1.TabIndex = 0;
            // 
            // RentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            Controls.Add(guna2Panel1);
            Name = "RentCard";
            Size = new Size(999, 54);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label startFinishLbl;
        private Label countLbl;
        private Label stadiumLbl;
        private Label userLbl;
        private Label price;
        private Label rentedAtLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
