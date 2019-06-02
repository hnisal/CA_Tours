namespace WindowsFormsApp1
{
    partial class DashboardManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardManager));
            this.lblManagerDashBoard = new System.Windows.Forms.Label();
            this.btnPackagesDashBoard = new System.Windows.Forms.Button();
            this.btnCustomersDashBoard = new System.Windows.Forms.Button();
            this.btnVhiclesDashBoard = new System.Windows.Forms.Button();
            this.btnhomedashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagerDashBoard
            // 
            this.lblManagerDashBoard.AutoSize = true;
            this.lblManagerDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerDashBoard.Location = new System.Drawing.Point(165, 43);
            this.lblManagerDashBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerDashBoard.Name = "lblManagerDashBoard";
            this.lblManagerDashBoard.Size = new System.Drawing.Size(272, 69);
            this.lblManagerDashBoard.TabIndex = 0;
            this.lblManagerDashBoard.Text = "Manager";
            this.lblManagerDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPackagesDashBoard
            // 
            this.btnPackagesDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackagesDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPackagesDashBoard.Location = new System.Drawing.Point(201, 204);
            this.btnPackagesDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnPackagesDashBoard.Name = "btnPackagesDashBoard";
            this.btnPackagesDashBoard.Size = new System.Drawing.Size(200, 62);
            this.btnPackagesDashBoard.TabIndex = 1;
            this.btnPackagesDashBoard.Text = "Packages";
            this.btnPackagesDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnCustomersDashBoard
            // 
            this.btnCustomersDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomersDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomersDashBoard.Location = new System.Drawing.Point(201, 347);
            this.btnCustomersDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomersDashBoard.Name = "btnCustomersDashBoard";
            this.btnCustomersDashBoard.Size = new System.Drawing.Size(200, 62);
            this.btnCustomersDashBoard.TabIndex = 2;
            this.btnCustomersDashBoard.Text = "Customers";
            this.btnCustomersDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnVhiclesDashBoard
            // 
            this.btnVhiclesDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVhiclesDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVhiclesDashBoard.Location = new System.Drawing.Point(201, 480);
            this.btnVhiclesDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnVhiclesDashBoard.Name = "btnVhiclesDashBoard";
            this.btnVhiclesDashBoard.Size = new System.Drawing.Size(200, 62);
            this.btnVhiclesDashBoard.TabIndex = 3;
            this.btnVhiclesDashBoard.Text = "Vehicles";
            this.btnVhiclesDashBoard.UseVisualStyleBackColor = true;
            this.btnVhiclesDashBoard.Click += new System.EventHandler(this.BtnVhiclesDashBoard_Click);
            // 
            // btnhomedashboard
            // 
            this.btnhomedashboard.BackColor = System.Drawing.Color.Silver;
            this.btnhomedashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhomedashboard.BackgroundImage")));
            this.btnhomedashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhomedashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomedashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomedashboard.ForeColor = System.Drawing.Color.White;
            this.btnhomedashboard.Location = new System.Drawing.Point(537, 610);
            this.btnhomedashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnhomedashboard.Name = "btnhomedashboard";
            this.btnhomedashboard.Size = new System.Drawing.Size(58, 56);
            this.btnhomedashboard.TabIndex = 21;
            this.btnhomedashboard.UseVisualStyleBackColor = false;
            // 
            // DashboardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(619, 690);
            this.Controls.Add(this.btnhomedashboard);
            this.Controls.Add(this.btnVhiclesDashBoard);
            this.Controls.Add(this.btnCustomersDashBoard);
            this.Controls.Add(this.btnPackagesDashBoard);
            this.Controls.Add(this.lblManagerDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardManager";
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
        private System.Windows.Forms.Button btnhomedashboard;
    }
}