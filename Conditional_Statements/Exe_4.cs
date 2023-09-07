using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_4
    {
        //4. Write a C# Sharp program to find out whether a given year is a leap year or not.

        public static void CheckInput()
        {
            Console.WriteLine("Enter a year to check whether it is a leap year or not");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400) == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
                
            else if ((year % 100) == 0)
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
                
            else if ((year % 4) == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }

            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
                
        }
    }
}
