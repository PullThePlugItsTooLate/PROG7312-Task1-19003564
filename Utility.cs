using System;
using System.Collections.Generic;
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
    class Utility
    {
        //------------------------------CODE-ATTRIBUTION----------------------------------------
        // DETAILS IN LINE 54
        public static Random randomN = new Random(); // Create object of type Random
        private static Random randomA = new Random(); // Create object of type Random
        //---------------------------------ENDS-HERE--------------------------------------------

        // Due to time constraints a linked list was not implemented, however, attempts were made - https://github.com/PullThePlugItsTooLate/LinkedListApplication
        public static List<Book> lstCallNumbers = new List<Book>(); // Create list of type book
        public static List<Book> lstOrderedBooks = new List<Book>(); // Create list of type book
        public static List<Book> lstOrderedBooksDups = new List<Book>(); // Create list of type book
        public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Stores the alphabet
        public static List<string> lstTipJar = new List<string> // Create list of type string, populate it with related strings
        {
            "Tip: Left click on a book, hold and move the mouse to drag, then release left click to drop",
            "Tip: Drag all the books to the empty slots",
            "Tip: Swap the books until they are in the correct order",
            "GREAT WORK CHAMP",
            "PUT THE BOOKS IN THE RIGHT ORDER"
        };
        public static List<string> lstCompliments = new List<string> // Create list of type string, populate it with related strings
        { 
            "Well Done!!!",
            "That was incredible!!!",
            "Please do that again, I didn't have my camera out :o",
            "Absolutely masterful!!!",
            "Keep up the good work!",
            "Are you a match-stick? Cause you're on Fire!",
            "Are you secretly a grand-master librarian?"
        };

        public static string GenerateCompliment() //Picks a random Compliment
        {
            int i = randomN.Next(0, 7); // Generates a random number and uses that number as an index
            return lstCompliments[i]; // Returns the string that was selected
        }

        public static void GenerateDeweyData()
        {
            lstCallNumbers.Clear(); // Clears the list 
            for (int i = 0; i < 10; i++) // Runs the for loop for 10 times because there are 10 books
            {
                //---------------------------------CODE-ATTRIBUTION-----------------------------------
                // URL: https://www.educative.io/edpresso/how-to-generate-a-random-integer-in-c-sharp
                // AUTHOR: Edpresso Team - https://www.educative.io/profile/view/6547532599525376
                // DATE ACCESSED: 22 SEPTEMBER 2021
                // YEAR: NULL
                string callNumberW = randomN.Next(0, 1000).ToString();// less than 1000, does not generate 1000 as a number
                string callNumberD = "." + randomN.Next(0, 1000).ToString();
                //------------------------------------ENDS-HERE--------------------------------------

                if (callNumberD.Equals("0")) // If the generated number for the decimal portion is 0 then execute the following code
                {
                    callNumberD = ""; // Change the zero to a blank string for display purposes
                }
                string callNumber = callNumberW + callNumberD; // Concatenate the whole number and decimal number
                double deciNum = Convert.ToDouble(callNumber); // Convert the generated number to a double
                for (int j = 0; j < 3; j++) // Run this loop to generate exactly 3 random alphabets
                {
                    //--------------------------------CODE-ATTRIBUTION--------------------------------
                    // URL: https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
                    // AUTHOR: dtb - https://stackoverflow.com/users/76217/dtb
                    // DATE ACCESSED: 22 SEPTEMBER 2021
                    // YEAR: 2009
                    callNumber += chars[randomA.Next(0, 26)]; // Generates random alphabet and concatenates it
                    //-----------------------------------ENDS-HERE-------------------------------------
                }
                lstCallNumbers.Add(new Book(callNumber, deciNum)); // Adds the generated call number as a book object to the list
            }
            OrderDeweyData(); // Calls the OrderDeweyData method
        }

        public static void OrderDeweyData() 
        {
            // Duplicates can occur but then how would you remember which number had which alphabet and how would you put them back into the list at their correct positions 

            // Linq on its own cannot sort an alphanumeric value the way we need, for this application (A1, A11, A2) - https://stackoverflow.com/questions/5093842/alphanumeric-sorting-using-linq
            // Therefore the number and alphabet was seperated using an object class, then the decimal numbers alone was ordered
            // Once the 10 numbers have been sorted it is then in the right order (lowest to highest) and we can just display the decimal number + the alphabets associated with it
            // However what if a duplicate occurs, example 101.34[zsd], and 101.34[asd] but they both have different alphabets. It is very likely that
            // linq would order it like this 101.34[zsd] and then 101.34[asd] (this is because linq doesn't know the corresponding alphabets that go with each number, since they are seperate) 
            // this is not what we want since this is not in alphabetical order. We also need to cater for more than one duplicate

            lstOrderedBooks = lstCallNumbers.OrderBy(lst => lst.DeciNum).ToList(); // Uses linq to order only the number of the call number

            
            int c; // Create integer
            int lowestIndex = 11; // Assigns integer value to 11 because there is a max of 10 books
            for (int i = 0; i < lstOrderedBooks.Count; i++) // Executes the following code for the 10 books
            {
                c = 0; // Assign integer to zero
                for (int j = 0; j < lstOrderedBooks.Count; j++) // Executes the following code for the 10 books
                { // There are 2 for loops so that the first loop selects a book and then loops through the list again to find any duplicates that exist
                    if (lstOrderedBooks[i].DeciNum == lstOrderedBooks[j].DeciNum) // Executes the following code if there is a match
                    {
                        c++; // increment the c integer by 1
                        lowestIndex = i; // assign the lowest index for the duplicate 
                        if (c > 1) // Execute the following code if c is greater than 1, this means that a true duplicate is found and not just a copy of the same number that the program was looking for
                        {
                            lstOrderedBooksDups.Add(lstOrderedBooks[j]); // Pulls the duplicate from the ordered list and stores it in another list
                        }
                    }
                }

                if (lstOrderedBooksDups.Count > 0) // Executes if the list count is greater than 1, this means that there is indeed a duplicate and it needs to be handled
                {
                    lstOrderedBooksDups.Add(lstOrderedBooks[i]); // Add the original to the list
                    lstOrderedBooksDups = lstOrderedBooksDups.OrderBy(dup => dup.CallNumber).ToList(); // Use linq to sort the dup list, linq will not have any issues doing this because the decimal number is exactly the same and all it will be doing is sorting out the alphabets in the call numbers.
                    
                    for (int q = 0; q < lstOrderedBooksDups.Count; q++) // Run this loop for the count of lstOrderedBookDups
                    {
                        lstOrderedBooks[lowestIndex] = lstOrderedBooksDups[q]; // Since we know the lowest index of the original we can then increment the lowest index and put everything back to where it was
                        lowestIndex++; // Increments integer
                    }
                }
            }
        }

        public static void repositionBook(Button book) // Has a book object as a parameter
        {
            if (book.Location.X > 1380 || book.Location.X < -80 || book.Location.Y < -118 || book.Location.Y > 600) // If the location of the x or y value goes beyond the visible scope then execute the following code
            {
                book.Location = new Point(587, 393); // Take the book back to a visible region of the form
            }
        }
    }
}
