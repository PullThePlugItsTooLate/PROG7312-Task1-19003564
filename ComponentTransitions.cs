using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    public class ComponentTransitions
    {
        public static void FormTransition(Form frmInstance, Form frmMain)
        {
            //Used whenever the user is going from the main form to an external form
            frmInstance.Tag = frmMain;// The tag property stores the current instance of main form and calls it when the user taps the back button instead of creating another form
            frmInstance.Show(frmMain);// Shows the instance and passes the main form as an argument
            frmMain.Hide();// Hides the main form
        }

        public static void backButton(frmMainMenu frmMain, Form frmInstance)
        {
            frmMain.Show();// Shows the mainform
            frmInstance.Close();// Closes the instance form that was created

        }

        //------------------------------------------------CODE-ATTRIBUTION-------------------------------------------------------
        // URL: https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms
        // AUTHOR: AsfK - [Java Developer at Ex Libris]: https://stackoverflow.com/users/1281081/asfk
        // DATE ACCESSED: 22 SEPTEMBER 2021
        // YEAR: 2013

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//importing a dll, makes forms rounded at the edges
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);//use dll method to make form rounded

        //--------------------------------------------------ENDS-HERE---------------------------------------------------

        public static void backButton(frmMainMenu frmMain)
        {
            frmMain.Show();// Shows the mainform
        }
    }
}
