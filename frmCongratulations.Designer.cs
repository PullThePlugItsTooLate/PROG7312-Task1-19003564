namespace CallNumberClash
{
    partial class frmCongratulations
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblCongratulations = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblCompMsg = new System.Windows.Forms.Label();
            this.btnOkay = new CallNumberClash.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClose.Location = new System.Drawing.Point(418, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 17);
            this.lblClose.TabIndex = 21;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // lblCongratulations
            // 
            this.lblCongratulations.AutoSize = true;
            this.lblCongratulations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongratulations.ForeColor = System.Drawing.Color.Snow;
            this.lblCongratulations.Location = new System.Drawing.Point(129, 104);
            this.lblCongratulations.Name = "lblCongratulations";
            this.lblCongratulations.Size = new System.Drawing.Size(190, 20);
            this.lblCongratulations.TabIndex = 22;
            this.lblCongratulations.Text = "CONGRATULATIONS";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::CallNumberClash.Properties.Resources.education;
            this.pbIcon.Location = new System.Drawing.Point(162, 21);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(124, 69);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 23;
            this.pbIcon.TabStop = false;
            // 
            // lblCompMsg
            // 
            this.lblCompMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompMsg.ForeColor = System.Drawing.Color.Snow;
            this.lblCompMsg.Location = new System.Drawing.Point(20, 124);
            this.lblCompMsg.Name = "lblCompMsg";
            this.lblCompMsg.Size = new System.Drawing.Size(408, 92);
            this.lblCompMsg.TabIndex = 24;
            this.lblCompMsg.Text = "Well Done!";
            this.lblCompMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOkay.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnOkay.BorderColor = System.Drawing.Color.Teal;
            this.btnOkay.BorderRadius = 20;
            this.btnOkay.BorderSize = 3;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.ForeColor = System.Drawing.Color.White;
            this.btnOkay.Location = new System.Drawing.Point(185, 219);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(79, 40);
            this.btnOkay.TabIndex = 25;
            this.btnOkay.Text = "OK";
            this.btnOkay.TextColor = System.Drawing.Color.White;
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // frmCongratulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 284);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.lblCompMsg);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblCongratulations);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongratulations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCongratulations";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCongratulations;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblCompMsg;
        private RJButton btnOkay;
    }
}