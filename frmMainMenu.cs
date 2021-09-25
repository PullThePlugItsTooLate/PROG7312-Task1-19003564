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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            //------------------------------------------------CODE-ATTRIBUTION-------------------------------------------------------
            // DETAILS IN COMPONENTTRANSITIONS CLASS - LINE 27
            Region = System.Drawing.Region.FromHrgn(ComponentTransitions.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//makes the form rounded at the edges
            //--------------------------------------------------ENDS-HERE------------------------------------------------------------
        }

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {
            frmReplaceBooks frmInstance = new frmReplaceBooks(); // Creating an instance of replace books form
            ComponentTransitions.FormTransition(frmInstance, this); // Calls method FormTransition
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red; // Changes the color of the label to red
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.ButtonFace; // Changes the color of the label to button face
        }

        private void btnQuit_MouseHover(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.IndianRed; // Changes the color of the button to indian red
            btnQuit.BorderColor = Color.DarkOrange; // Changes the button border color of the button to dark orange
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.DarkTurquoise; // Changes the color of the button to dark turquoise
            btnQuit.BorderColor = Color.Teal; // Changes the button border color of the button to teal
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmAreYouSure frmAYS = new frmAreYouSure(); // Creates an instance of are you sure form
            frmAYS.ShowDialog(); // Shows the form instance as a dialog
        }
    }
}
