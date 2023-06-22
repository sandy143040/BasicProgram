using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class Ascii
    {
        public void AsciiValue()
        {
            Console.WriteLine("Enter a character:");
            char inputChar = Console.ReadKey().KeyChar;

            int asciiValue = Convert.ToInt32(inputChar);
            Console.WriteLine("\nThe ASCII value of " + inputChar + " is: " + asciiValue);
        }
    }
    
}
