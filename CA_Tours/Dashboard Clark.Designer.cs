namespace WindowsFormsApp1
{
    partial class DashboardCashier
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
            this.btnPaymentsDashBoard = new System.Windows.Forms.Button();
            this.btnReservationDashboard = new System.Windows.Forms.Button();
            this.btnCashierToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagerDashBoard
            // 
            this.lblManagerDashBoard.AutoSize = true;
            this.lblManagerDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerDashBoard.Location = new System.Drawing.Point(114, 24);
            this.lblManagerDashBoard.Name = "lblManagerDashBoard";
            this.lblManagerDashBoard.Size = new System.Drawing.Size(222, 55);
            this.lblManagerDashBoard.TabIndex = 0;
            this.lblManagerDashBoard.Text = "Manager";
            this.lblManagerDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPaymentsDashBoard
            // 
            this.btnPaymentsDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaymentsDashBoard.Location = new System.Drawing.Point(142, 166);
            this.btnPaymentsDashBoard.Name = "btnPaymentsDashBoard";
            this.btnPaymentsDashBoard.Size = new System.Drawing.Size(150, 50);
            this.btnPaymentsDashBoard.TabIndex = 1;
            this.btnPaymentsDashBoard.Text = "Payments";
            this.btnPaymentsDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnReservationDashboard
            // 
            this.btnReservationDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservationDashboard.Location = new System.Drawing.Point(142, 341);
            this.btnReservationDashboard.Name = "btnReservationDashboard";
            this.btnReservationDashboard.Size = new System.Drawing.Size(150, 50);
            this.btnReservationDashboard.TabIndex = 2;
            this.btnReservationDashboard.Text = "Reservations";
            this.btnReservationDashboard.UseVisualStyleBackColor = true;
            // 
            // btnCashierToHome
            // 
            this.btnCashierToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierToHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCashierToHome.Location = new System.Drawing.Point(26, 514);
            this.btnCashierToHome.Name = "btnCashierToHome";
            this.btnCashierToHome.Size = new System.Drawing.Size(75, 25);
            this.btnCashierToHome.TabIndex = 4;
            this.btnCashierToHome.Text = "Home";
            this.btnCashierToHome.UseVisualStyleBackColor = true;
            // 
            // DashboardCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.btnCashierToHome);
            this.Controls.Add(this.btnReservationDashboard);
            this.Controls.Add(this.btnPaymentsDashBoard);
            this.Controls.Add(this.lblManagerDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "DashboardCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerDashBoard;
        private System.Windows.Forms.Button btnPaymentsDashBoard;
        private System.Windows.Forms.Button btnReservationDashboard;
        private System.Windows.Forms.Button btnCashierToHome;
    }
}