using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class Swaping
    {
        public static void Swap(int num1, int num2)
        {
            Console.WriteLine("before swaping: num1 = " + num1 + ", num2 = " + num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping: num1 = " + num1 + ", num1 = " + num2);
        }
    }
}
