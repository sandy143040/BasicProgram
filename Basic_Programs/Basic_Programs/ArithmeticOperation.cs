using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class ArithmeticOperation
    {
        public void Calculation(int num1,int num2)
        {
            //Addition
            int sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);

            //Subtraction
            int difference = num1 - num2;
            Console.WriteLine("The subtraction is: " + difference);

            //Multiplication
            int product = num1 * num2;
            Console.WriteLine("The product is: " + product);

            //Division
            int quotient = num1 / num2;
            Console.WriteLine("The Quotient is: " + quotient);

            //Modulus
            int remainder = num1 % num2;
            Console.WriteLine("The remainder is: "+remainder);

            // Increment
            num1++;
            Console.WriteLine("Incremented num1: " + num1);

            // Decrement
            num2--;
            Console.WriteLine("Decremented num2: " + num2);
        }
    }
}
