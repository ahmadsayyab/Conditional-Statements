using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_22
    {
       // 22. Write C# Sharp program to read any Month Number in integer and display Month name


        public static void ShowMonthName()
        {
            Console.WriteLine("Enter a digit to show display Month name");
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
                    Console.WriteLine(digit[1]);
                    break;
                case 2:
                    Console.WriteLine(digit[2]);
                    break;
                case 3:
                    Console.WriteLine(digit[3]);
                    break;
                case 4:
                    Console.WriteLine(digit[4]);
                    break;
                case 5:
                    Console.WriteLine(digit[5]);
                    break;
                case 6:
                    Console.WriteLine(digit[6]);
                    break;
                case 7:
                    Console.WriteLine(digit[7]);
                    break;
                case 8:
                    Console.WriteLine(digit[8]);
                    break;
                case 9:
                    Console.WriteLine(digit[9]);
                    break;
                case 10:
                    Console.WriteLine(digit[10]);
                    break;
                case 11:
                    Console.WriteLine(digit[11]);
                    break;
                case 12:
                    Console.WriteLine(digit[12]);
                    break;
                default:
                    Console.WriteLine("Enter digits in 1-12 range only");
                    break;
            }
}
