namespace CallNumberClash
{
    partial class frmMainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCallNumberClash = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnReplaceBooks = new CallNumberClash.RJButton();
            this.btnIdentifyAreas = new CallNumberClash.RJButton();
            this.btnFindCallNumbers = new CallNumberClash.RJButton();
            this.btnQuit = new CallNumberClash.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CallNumberClash.Properties.Resources.shelf;
            this.pictureBox1.Location = new System.Drawing.Point(82, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblCallNumberClash
            // 
            this.lblCallNumberClash.AutoSize = true;
            this.lblCallNumberClash.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallNumberClash.ForeColor = System.Drawing.Color.White;
            this.lblCallNumberClash.Location = new System.Drawing.Point(41, 162);
            this.lblCallNumberClash.Name = "lblCallNumberClash";
            this.lblCallNumberClash.Size = new System.Drawing.Size(242, 26);
            this.lblCallNumberClash.TabIndex = 4;
            this.lblCallNumberClash.Text = "CALL NUMBER CLASH";
            this.lblCallNumberClash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClose.Location = new System.Drawing.Point(303, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 17);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReplaceBooks.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnReplaceBooks.BorderColor = System.Drawing.Color.Teal;
            this.btnReplaceBooks.BorderRadius = 20;
            this.btnReplaceBooks.BorderSize = 3;
            this.btnReplaceBooks.FlatAppearance.BorderSize = 0;
            this.btnReplaceBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceBooks.ForeColor = System.Drawing.Color.White;
            this.btnReplaceBooks.Location = new System.Drawing.Point(55, 220);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(214, 40);
            this.btnReplaceBooks.TabIndex = 5;
            this.btnReplaceBooks.Text = "REPLACE BOOKS";
            this.btnReplaceBooks.TextColor = System.Drawing.Color.White;
            this.btnReplaceBooks.UseVisualStyleBackColor = false;
            this.btnReplaceBooks.Click += new System.EventHandler(this.btnReplaceBooks_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnIdentifyAreas.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnIdentifyAreas.BorderColor = System.Drawing.Color.Teal;
            this.btnIdentifyAreas.BorderRadius = 20;
            this.btnIdentifyAreas.BorderSize = 3;
            this.btnIdentifyAreas.Enabled = false;
            this.btnIdentifyAreas.FlatAppearance.BorderSize = 0;
            this.btnIdentifyAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentifyAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyAreas.ForeColor = System.Drawing.Color.White;
            this.btnIdentifyAreas.Location = new System.Drawing.Point(55, 276);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(214, 40);
            this.btnIdentifyAreas.TabIndex = 7;
            this.btnIdentifyAreas.Text = "IDENTIFY AREAS";
            this.btnIdentifyAreas.TextColor = System.Drawing.Color.White;
            this.btnIdentifyAreas.UseVisualStyleBackColor = false;
            // 
            // btnFindCallNumbers
            // 
            this.btnFindCallNumbers.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnFindCallNumbers.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnFindCallNumbers.BorderColor = System.Drawing.Color.Teal;
            this.btnFindCallNumbers.BorderRadius = 20;
            this.btnFindCallNumbers.BorderSize = 3;
            this.btnFindCallNumbers.Enabled = false;
            this.btnFindCallNumbers.FlatAppearance.BorderSize = 0;
            this.btnFindCallNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCallNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCallNumbers.ForeColor = System.Drawing.Color.White;
            this.btnFindCallNumbers.Location = new System.Drawing.Point(55, 332);
            this.btnFindCallNumbers.Name = "btnFindCallNumbers";
            this.btnFindCallNumbers.Size = new System.Drawing.Size(214, 40);
            this.btnFindCallNumbers.TabIndex = 8;
            this.btnFindCallNumbers.Text = "FIND CALL NUMBERS";
            this.btnFindCallNumbers.TextColor = System.Drawing.Color.White;
            this.btnFindCallNumbers.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnQuit.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnQuit.BorderColor = System.Drawing.Color.Teal;
            this.btnQuit.BorderRadius = 20;
            this.btnQuit.BorderSize = 3;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(55, 388);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(214, 40);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.TextColor = System.Drawing.Color.White;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            this.btnQuit.MouseHover += new System.EventHandler(this.btnQuit_MouseHover);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(333, 474);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnFindCallNumbers);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnReplaceBooks);
            this.Controls.Add(this.lblCallNumberClash);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Number Clash Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCallNumberClash;
        private RJButton btnReplaceBooks;
        private System.Windows.Forms.Label lblClose;
        private RJButton btnIdentifyAreas;
        private RJButton btnFindCallNumbers;
        private RJButton btnQuit;
    }
}

