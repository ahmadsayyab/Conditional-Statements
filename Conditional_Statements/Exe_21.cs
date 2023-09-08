using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_21
    {
        //21. Write a program in C# Sharp to read any digit, display in the word.


        public static void ShowDigitInWords()
        {
            Console.WriteLine("Enter any digit to convert it into words");
            int num = int.Parse(Console.ReadLine());

            Dictionary<int , string> digit = new Dictionary<int, string>
            {
                {0 , "zero" },
                {1 , "One" },
                {2 , "Two" },
                {3 , "Three" },
                {4 , "Four" },
                {5 , "Five" },
                {6 , "Six" },
                {7 , "Seven" },
                {8 , "Eight" },
                {9 , "Nine" },
            };

            switch (num)
            {
                case 0:
                    Console.WriteLine(digit[0]);
                    break;
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
                default:
                    Console.WriteLine("Enter digits in 0-9 range only");
                    break;
            }
        }
    }
}
