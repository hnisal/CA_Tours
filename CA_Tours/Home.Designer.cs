namespace CA_Tours
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.lblbluehome = new System.Windows.Forms.Label();
            this.lblhome = new System.Windows.Forms.Label();
            this.btnmanager = new System.Windows.Forms.Button();
            this.btncashier = new System.Windows.Forms.Button();
            this.btnclerk = new System.Windows.Forms.Button();
            this.picboxhome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxhome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbluehome
            // 
            this.lblbluehome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblbluehome.Location = new System.Drawing.Point(363, 29);
            this.lblbluehome.Name = "lblbluehome";
            this.lblbluehome.Size = new System.Drawing.Size(630, 455);
            this.lblbluehome.TabIndex = 0;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblhome.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblhome.Location = new System.Drawing.Point(639, 190);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(91, 36);
            this.lblhome.TabIndex = 5;
            this.lblhome.Text = "HOME";
            // 
            // btnmanager
            // 
            this.btnmanager.BackColor = System.Drawing.Color.DarkBlue;
            this.btnmanager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmanager.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanager.ForeColor = System.Drawing.Color.White;
            this.btnmanager.Location = new System.Drawing.Point(554, 269);
            this.btnmanager.Name = "btnmanager";
            this.btnmanager.Size = new System.Drawing.Size(271, 30);
            this.btnmanager.TabIndex = 4;
            this.btnmanager.Text = "MANAGER";
            this.btnmanager.UseVisualStyleBackColor = false;
            // 
            // btncashier
            // 
            this.btncashier.BackColor = System.Drawing.Color.DarkBlue;
            this.btncashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncashier.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncashier.ForeColor = System.Drawing.Color.White;
            this.btncashier.Location = new System.Drawing.Point(554, 333);
            this.btncashier.Name = "btncashier";
            this.btncashier.Size = new System.Drawing.Size(271, 30);
            this.btncashier.TabIndex = 4;
            this.btncashier.Text = "CASHIER";
            this.btncashier.UseVisualStyleBackColor = false;
            // 
            // btnclerk
            // 
            this.btnclerk.BackColor = System.Drawing.Color.DarkBlue;
            this.btnclerk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclerk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclerk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclerk.ForeColor = System.Drawing.Color.White;
            this.btnclerk.Location = new System.Drawing.Point(554, 392);
            this.btnclerk.Name = "btnclerk";
            this.btnclerk.Size = new System.Drawing.Size(271, 30);
            this.btnclerk.TabIndex = 4;
            this.btnclerk.Text = "RESERVATION CLERK";
            this.btnclerk.UseVisualStyleBackColor = false;
            // 
            // picboxhome
            // 
            this.picboxhome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picboxhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxhome.BackgroundImage")));
            this.picboxhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxhome.Location = new System.Drawing.Point(632, 105);
            this.picboxhome.Name = "picboxhome";
            this.picboxhome.Size = new System.Drawing.Size(98, 82);
            this.picboxhome.TabIndex = 6;
            this.picboxhome.TabStop = false;
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 683);
            this.Controls.Add(this.picboxhome);
            this.Controls.Add(this.btnclerk);
            this.Controls.Add(this.btncashier);
            this.Controls.Add(this.btnmanager);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.lblbluehome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C A Lanka Travels";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbluehome;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Button btnmanager;
        private System.Windows.Forms.Button btncashier;
        private System.Windows.Forms.Button btnclerk;
        private System.Windows.Forms.PictureBox picboxhome;
    }
}