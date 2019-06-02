﻿namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblManagerDashBoard = new System.Windows.Forms.Label();
            this.btnPaymentsDashBoard = new System.Windows.Forms.Button();
            this.btnReservationDashboard = new System.Windows.Forms.Button();
            this.btnhomedashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagerDashBoard
            // 
            this.lblManagerDashBoard.AutoSize = true;
            this.lblManagerDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerDashBoard.Location = new System.Drawing.Point(173, 43);
            this.lblManagerDashBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerDashBoard.Name = "lblManagerDashBoard";
            this.lblManagerDashBoard.Size = new System.Drawing.Size(242, 69);
            this.lblManagerDashBoard.TabIndex = 0;
            this.lblManagerDashBoard.Text = "Cashier";
            this.lblManagerDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPaymentsDashBoard
            // 
            this.btnPaymentsDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaymentsDashBoard.Location = new System.Drawing.Point(201, 220);
            this.btnPaymentsDashBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaymentsDashBoard.Name = "btnPaymentsDashBoard";
            this.btnPaymentsDashBoard.Size = new System.Drawing.Size(200, 62);
            this.btnPaymentsDashBoard.TabIndex = 5;
            this.btnPaymentsDashBoard.Text = "Payments";
            this.btnPaymentsDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnReservationDashboard
            // 
            this.btnReservationDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservationDashboard.Location = new System.Drawing.Point(201, 401);
            this.btnReservationDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservationDashboard.Name = "btnReservationDashboard";
            this.btnReservationDashboard.Size = new System.Drawing.Size(200, 62);
            this.btnReservationDashboard.TabIndex = 6;
            this.btnReservationDashboard.Text = "Reservations";
            this.btnReservationDashboard.UseVisualStyleBackColor = true;
            // 
            // btnhomedashboard
            // 
            this.btnhomedashboard.BackColor = System.Drawing.Color.Silver;
            this.btnhomedashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhomedashboard.BackgroundImage")));
            this.btnhomedashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhomedashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomedashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomedashboard.ForeColor = System.Drawing.Color.White;
            this.btnhomedashboard.Location = new System.Drawing.Point(539, 611);
            this.btnhomedashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnhomedashboard.Name = "btnhomedashboard";
            this.btnhomedashboard.Size = new System.Drawing.Size(58, 56);
            this.btnhomedashboard.TabIndex = 20;
            this.btnhomedashboard.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 690);
            this.Controls.Add(this.btnhomedashboard);
            this.Controls.Add(this.btnReservationDashboard);
            this.Controls.Add(this.btnPaymentsDashBoard);
            this.Controls.Add(this.lblManagerDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerDashBoard;
        private System.Windows.Forms.Button btnPaymentsDashBoard;
        private System.Windows.Forms.Button btnReservationDashboard;
        private System.Windows.Forms.Button btnhomedashboard;
    }
}