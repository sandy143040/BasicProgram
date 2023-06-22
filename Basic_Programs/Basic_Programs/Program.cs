using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while(true)
           {
                Console.WriteLine("Please choose 1Program from below option");
                Console.WriteLine("1.Data types");
                Console.WriteLine("2.Swaping");
                Console.WriteLine("3.Area of Circle");
                Console.WriteLine("4.ASCCI value");
                Console.WriteLine("5.Days");
                Console.WriteLine("6.Arithmetic Operation");
                Console.WriteLine("0.Exit");
                
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        DataTypes dataTypes = new DataTypes();
                        dataTypes.Size();
                        break;
                    case 2:
                        Console.WriteLine("Enter First number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Swaping.Swap(num1, num2);
                        break;
                    case 3:
                        
                        AreaOfCircle areaOfCircle = new AreaOfCircle();
                        areaOfCircle.Calculation();
                        break;
                    case 4:
                        Ascii ascii = new Ascii();
                        ascii.AsciiValue();
                        break;
                    case 5:
                        Console.WriteLine("Enter the number of days:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Days.Convert(n);
                        break;
                    case 6:
                        Console.WriteLine("Enter first value");
                        int first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second value");
                        int second = Convert.ToInt32(Console.ReadLine());
                        ArithmeticOperation arithmeticOperation = new ArithmeticOperation();
                        arithmeticOperation.Calculation(first,second);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option.Please choose correct option");
                        break;
                }
           }
        }
    }
}
