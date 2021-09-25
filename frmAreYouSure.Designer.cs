namespace CallNumberClash
{
    partial class frmAreYouSure
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
            this.lblCongratulations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNo = new CallNumberClash.RJButton();
            this.btnYes = new CallNumberClash.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCongratulations
            // 
            this.lblCongratulations.AutoSize = true;
            this.lblCongratulations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongratulations.ForeColor = System.Drawing.Color.Snow;
            this.lblCongratulations.Location = new System.Drawing.Point(72, 163);
            this.lblCongratulations.Name = "lblCongratulations";
            this.lblCongratulations.Size = new System.Drawing.Size(269, 20);
            this.lblCongratulations.TabIndex = 23;
            this.lblCongratulations.Text = "Are you sure you want to Quit?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(182, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "QUIT";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNo.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnNo.BorderColor = System.Drawing.Color.Teal;
            this.btnNo.BorderRadius = 20;
            this.btnNo.BorderSize = 3;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(262, 216);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(79, 40);
            this.btnNo.TabIndex = 26;
            this.btnNo.Text = "NO";
            this.btnNo.TextColor = System.Drawing.Color.White;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnYes.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnYes.BorderColor = System.Drawing.Color.Teal;
            this.btnYes.BorderRadius = 20;
            this.btnYes.BorderSize = 3;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(76, 216);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(79, 40);
            this.btnYes.TabIndex = 27;
            this.btnYes.Text = "YES";
            this.btnYes.TextColor = System.Drawing.Color.White;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnYes.MouseLeave += new System.EventHandler(this.btnYes_MouseLeave);
            this.btnYes.MouseHover += new System.EventHandler(this.btnYes_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CallNumberClash.Properties.Resources.remove;
            this.pictureBox1.Location = new System.Drawing.Point(146, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClose.Location = new System.Drawing.Point(396, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 17);
            this.lblClose.TabIndex = 29;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // frmAreYouSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(425, 302);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCongratulations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAreYouSure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAreYouSure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongratulations;
        private System.Windows.Forms.Label label1;
        private RJButton btnNo;
        private RJButton btnYes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
    }
}