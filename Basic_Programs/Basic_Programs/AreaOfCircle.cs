using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class AreaOfCircle
    {
        public void Calculation()
        {
            double radius;
            double area;

            Console.WriteLine("Enter the radius of the circle:");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
