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
    public partial class frmCongratulations : Form
    {
        public frmCongratulations()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(ComponentTransitions.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//makes the form rounded at the edges
            lblCompMsg.Text = Utility.GenerateCompliment(); // Display compliment
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close(); // Closes this form
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red; // Changes the color of the lable to red
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.ButtonFace; // Changes the color of the lable to button face
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close(); // Closes this form
        }
    }
}
