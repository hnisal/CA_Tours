namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.lblManagerDashBoard = new System.Windows.Forms.Label();
            this.btnPackagesDashBoard = new System.Windows.Forms.Button();
            this.btnCustomersDashBoard = new System.Windows.Forms.Button();
            this.btnVhiclesDashBoard = new System.Windows.Forms.Button();
            this.btnHomeDashBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagerDashBoard
            // 
            this.lblManagerDashBoard.AutoSize = true;
            this.lblManagerDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerDashBoard.Location = new System.Drawing.Point(114, 24);
            this.lblManagerDashBoard.Name = "lblManagerDashBoard";
            this.lblManagerDashBoard.Size = new System.Drawing.Size(197, 55);
            this.lblManagerDashBoard.TabIndex = 0;
            this.lblManagerDashBoard.Text = "Cashier";
            this.lblManagerDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPackagesDashBoard
            // 
            this.btnPackagesDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackagesDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPackagesDashBoard.Location = new System.Drawing.Point(142, 166);
            this.btnPackagesDashBoard.Name = "btnPackagesDashBoard";
            this.btnPackagesDashBoard.Size = new System.Drawing.Size(150, 50);
            this.btnPackagesDashBoard.TabIndex = 1;
            this.btnPackagesDashBoard.Text = "Packages";
            this.btnPackagesDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnCustomersDashBoard
            // 
            this.btnCustomersDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomersDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomersDashBoard.Location = new System.Drawing.Point(142, 282);
            this.btnCustomersDashBoard.Name = "btnCustomersDashBoard";
            this.btnCustomersDashBoard.Size = new System.Drawing.Size(150, 50);
            this.btnCustomersDashBoard.TabIndex = 2;
            this.btnCustomersDashBoard.Text = "Customers";
            this.btnCustomersDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnVhiclesDashBoard
            // 
            this.btnVhiclesDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVhiclesDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVhiclesDashBoard.Location = new System.Drawing.Point(142, 390);
            this.btnVhiclesDashBoard.Name = "btnVhiclesDashBoard";
            this.btnVhiclesDashBoard.Size = new System.Drawing.Size(150, 50);
            this.btnVhiclesDashBoard.TabIndex = 3;
            this.btnVhiclesDashBoard.Text = "Vehicles";
            this.btnVhiclesDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnHomeDashBoard
            // 
            this.btnHomeDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHomeDashBoard.Location = new System.Drawing.Point(26, 514);
            this.btnHomeDashBoard.Name = "btnHomeDashBoard";
            this.btnHomeDashBoard.Size = new System.Drawing.Size(75, 25);
            this.btnHomeDashBoard.TabIndex = 4;
            this.btnHomeDashBoard.Text = "Home";
            this.btnHomeDashBoard.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.btnHomeDashBoard);
            this.Controls.Add(this.btnVhiclesDashBoard);
            this.Controls.Add(this.btnCustomersDashBoard);
            this.Controls.Add(this.btnPackagesDashBoard);
            this.Controls.Add(this.lblManagerDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerDashBoard;
        private System.Windows.Forms.Button btnPackagesDashBoard;
        private System.Windows.Forms.Button btnCustomersDashBoard;
        private System.Windows.Forms.Button btnVhiclesDashBoard;
        private System.Windows.Forms.Button btnHomeDashBoard;
    }
}