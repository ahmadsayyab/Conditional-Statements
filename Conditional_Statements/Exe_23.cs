using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_23
    {
        //23. Write a program in C# Sharp to read any Month Number in integer
        //and display the number of days for this month.



        public static void ShowMonthDays()
        {
            Console.WriteLine("Enter a digit to show display Month Days");
            int num = int.Parse(Console.ReadLine());

            Dictionary<int, string> digit = new Dictionary<int, string>
            {

                {1 , "January" },
                {2 , "February" },
                {3 , "March" },
                {4 , "April" },
                {5 , "May" },
                {6 , "June" },
                {7 , "July" },
                {8 , "August" },
                {9 , "September" },
                {10 , "Otober" },
                {11 , "November" },
                {12 , "December" },
            };

            switch (num)
            {

                case 1:
                    Console.WriteLine($"{digit[1]} has: {31} days ");
                    break;
                case 2:
                    Console.WriteLine($"{digit[2]} has: {28} or {29} days ");
                    break;
                case 3:
                    Console.WriteLine($"{digit[3]} has: {31} days ");
                    break;
                case 4:
                    Console.WriteLine($"{digit[4]} has {30} days ");
                    break;
                case 5:
                    Console.WriteLine($"{digit[5]} has: {31} days ");
                    break;
                case 6:
                    Console.WriteLine($"{digit[6]} has: {30} days ");
                    break;
                case 7:
                    Console.WriteLine($"{digit[7]} has: {31} days ");
                    break;
                case 8:
                    Console.WriteLine($"{digit[8]} has {31} days ");
                    break;
                case 9:
                    Console.WriteLine($"{digit[9]} has {30} days ");
                    break;
                case 10:
                    Console.WriteLine($"{digit[10]} has: {31} days ");
                    break;
                case 11:
                    Console.WriteLine($"{digit[11]} has: {30} days ");
                    break;
                case 12:
                    Console.WriteLine($"{digit[12]} has: {31} days ");
                    break;
                default:
                    Console.WriteLine("Enter digits in 1-12 range only");
                    break;
            }
        }
    }
}
