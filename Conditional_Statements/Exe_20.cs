using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_20
    {
        //20. Write a C# Sharp program to read any day number as an integer
        //and display the name of the day as a word.

        public static void ShowDayName()
        {
            Console.WriteLine("Enter a day number as an integer");
            int day_num = int.Parse(Console.ReadLine());

            switch(day_num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Only enter integer in range 1-7");
                    break;
            }
        }
    }
}
