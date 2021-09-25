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
    public partial class frmReplaceBooks : Form
    {
        public static List<Button> lstBooks; // Creating list
        public static List<Panel> lstBookShelf; // Creating list

        public frmReplaceBooks()
        {
            //Component Intialization
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(ComponentTransitions.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//makes the form rounded at the edges

            lstBooks = new List<Button>() // Populating list with buttons
            {
                btnBook1,
                btnBook2,
                btnBook3,
                btnBook4,
                btnBook5,
                btnBook6,
                btnBook7,
                btnBook8,
                btnBook9,
                btnBook10
            };

            lstBookShelf = new List<Panel>() // Populating list with panels
            {
                pnlBookShelf1,
                pnlBookShelf2,
                pnlBookShelf3,
                pnlBookShelf4,
                pnlBookShelf5,
                pnlBookShelf6,
                pnlBookShelf7,
                pnlBookShelf8,
                pnlBookShelf9,
                pnlBookShelf10
            };

            ComponentPrep(); // Calling method
        }

        public void ComponentPrep() 
        {
            pbBookOrder.Value = 0; // Setting progress bar value to zero
            Utility.GenerateDeweyData(); // Generating the call numbers
            Utility.OrderDeweyData(); // Ordering the call numbers
            lblHeader.Text = Utility.lstTipJar[4]; // Setting the text property to the appropriate heading
            lblTip.Text = Utility.lstTipJar[0]; // Setting the text property to the appropriate tip

            foreach (Panel pnl in lstBookShelf)
            {
                pnl.Enabled = true; // Enabling all the panels
            }

            int x = 46; // Assigning x as 46 which is the starting x value on the x axis for the location property
            int i = 0; // Counter to be used as an index for list storing the call numbers
            foreach (Button book in lstBooks) // Run for each button object stored in lstBooks
            {
                book.Enabled = true; // Enabling all buttons
                book.Location = new Point(x, 393); // Setting the location of all buttons
                ControlExtension.Draggable(book, true); // Allow the button to be draggable
                book.Text = Utility.lstCallNumbers[i].CallNumber; // Assigns a call number to each button
                x += 135; // Incrementing the x value by 135 to space out the buttons
                i++; // Incrementing the i value by 1 to traverse the list;
            }

            btnReturn.Visible = false; // Hides button
            btnGoAgain.Visible = false; // Hides button
            lblTip.Visible = true; // Shows label
        }

        private void frmReplaceBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentTransitions.backButton((frmMainMenu)Tag); // Calls backButton method and calls the tag property for this form which stores frmMainMenu
        }

        public void CheckIfDragOutOfBounds() 
        {
            foreach (Button book in lstBooks) // Execute the following code for each button object in lstBooks
            {
                Utility.repositionBook(book); // Calls the repositionBook method
            }
        }

        public bool CheckIfAllBooksAreDragged() 
        {
            int allOnShelf = 0; // Creates an integer variable and assign it to 0
            int isOnShelf; // Creates an integer variable

            foreach (Button book in lstBooks)
            {
                isOnShelf = 0; // Sets integer variable to 0
                foreach (Panel shelf in lstBookShelf) // Execute the following code for each panel object in lstBookShelf
                {
                    //-------------------------------CODE-ATTRIBUTION-----------------------------
                    // URL: https://stackoverflow.com/questions/13917537/how-to-check-if-two-controls-are-overlapping-in-windows-forms
                    // AUTHOR: Codefun64 - https://stackoverflow.com/users/1762453/codefun64
                    // DATE ACCESSED: 22 SEPTEMBER 2021
                    // YEAR: 2014

                    if (shelf.Bounds.IntersectsWith(book.Bounds)) // Execute the following code if the shelf object intersects with the book object
                    {
                        //----------------------------ENDS-HERE----------------------------------
                        isOnShelf++; // Increment integer by 1
                        allOnShelf++; // Increment integer by 1
                    }
                }

                if (isOnShelf == 0) // Execute the following code if isOnShelf is equal to 0
                {// If this executes this means that a this currect book has not been dragged to the shelf
                    lblTip.Text = Utility.lstTipJar[1]; // Display the appropriate tip
                }
            }

            if (allOnShelf == 10) // Execute the following code if allOnshelf is equal to 10
            {// If this executes this means that 
                return true; // Return true when this method is called
            }
            else 
            {
                return false; // Return false when this method is called
            }
        }

        public void CheckIfAllBooksInOrder() 
        {
            int i = 0; // Create integer and assign to zero
            if (CheckIfAllBooksAreDragged()) // If all books are dragged onto the shelf slots then execute the following code
            {
                lblTip.Text = Utility.lstTipJar[2]; // Display the appropriate tip
                pbBookOrder.Value = 0; // Set the progress bar value to zero
                foreach (Book book in Utility.lstOrderedBooks) // Execute the following code for each book object in lstOrderedBooks
                {
                    foreach (Button callNumber in lstBooks) // Execute the following code for each button in lstBooks
                    {
                        if (callNumber.Text.Equals(book.CallNumber)) // Execute the following code if buttons text property is equal to the book object in lstOrderedBooks
                        {
                            pbBookOrder.Value += 10; // Since it matches then increase the progress bar by 10 since there are 10 books and a progress bar has a max value of 100
                            if (!lstBookShelf[i].Bounds.IntersectsWith(callNumber.Bounds)) // If it does not match then simply deduct what was already allocated
                            {
                                pbBookOrder.Value -= 10; // Deduct 10 from the progress bar value if the book does not match the correct order
                            }
                        }
                    }
                    i++; // Increment integer by 1
                }
                if (pbBookOrder.Value == 100) // Execute the following code if the progress bar fills up to a 100
                {
                    lblTip.Visible = false; // Hide the tip label
                    frmCongratulations frmCongrats = new frmCongratulations(); // Create an instance of the congratulations form
                    frmCongrats.ShowDialog(); // Show the created form instance as a dialog
                    
                    foreach (Panel pnl in lstBookShelf)
                    {
                        pnl.Enabled = false; // Disable all panels
                    }

                    foreach (Button btn in lstBooks)
                    {
                        btn.Enabled = false; // Disable all buttons
                    }

                    btnReturn.Visible = true; // Show button
                    btnGoAgain.Visible = true; // Show button
                    lblHeader.Text = Utility.lstTipJar[3]; // Display the appropriate header
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ComponentTransitions.backButton((frmMainMenu)Tag, this); // Calls back button method and sends this forms tag property
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red; // Sets the color of the label to red
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.ButtonFace; // Sets the color of the label to button face
        }

        private void btnGoAgain_Click(object sender, EventArgs e)
        {
            ComponentPrep(); // Calls ComponentPrep method
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            ComponentTransitions.backButton((frmMainMenu)Tag, this); // Calls back button method and sends this forms tag property
        }

        private void btnBook1_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook2_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook3_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook4_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook5_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook6_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook7_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook8_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook9_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }

        private void btnBook10_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfAllBooksInOrder(); // Calls CheckIfAllBooksInOrder method
            CheckIfDragOutOfBounds(); // Calls CheckIfDragOutOfBounds method
        }
    }
}
