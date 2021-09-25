using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// STUDENT NAME: SUVASHIN MOODLIAR
/// STUDENT NUMBER: 19003564
/// TASK: 1
/// </summary>

namespace CallNumberClash
{
    public partial class frmAreYouSure : Form
    {
        public frmAreYouSure()
        {
            InitializeComponent(); // Initialize components
            Region = System.Drawing.Region.FromHrgn(ComponentTransitions.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//makes the form rounded at the edges
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit application
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes this form
        }

        private void btnYes_MouseHover(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.IndianRed; // Set color of button to indian red
            btnYes.BorderColor = Color.DarkOrange; // Set color of button border to dark orange
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.DarkTurquoise; // Set color of button to dark turquoise
            btnYes.BorderColor = Color.Teal; // Set color of button border to teal
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes this form
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red; // Set color of label to red
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.ButtonFace; // Set color of label to button face
        }
    }
}
