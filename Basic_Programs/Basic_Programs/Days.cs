using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class Days
    {
        public static void Convert(int n)
        {
            int totalDays = n;
            if (totalDays >= 0)
            {
                int years = totalDays / 365;
                int weeks = (totalDays % 365) / 7;
                int remainingDays = (totalDays % 365) % 7;

                Console.WriteLine("Years: " + years);
                Console.WriteLine("Weeks: " + weeks);
                Console.WriteLine("Days: " + remainingDays);
            }
        }
    }
}
