using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// STUDENT NAME: SUVASHIN MOODLIAR
/// STUDENT NUMBER: 19003564
/// TASK: 1
/// </summary>

namespace CallNumberClash
{
    class Book
    {
        private string callNumber; // Private attributes
        private double deciNum;

        public Book(string callNumber, double deciNum) // Constructor 
        {
            this.callNumber = callNumber;
            this.deciNum = deciNum;
        }


        public Book() // Default constructor
        {
        }

        public string CallNumber { get => callNumber; set => callNumber = value; } // Get and Set methods
        public double DeciNum { get => deciNum; set => deciNum = value; } // Get and Set methods
    }
}
