using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_3
    {
        //3. Write a C# Sharp program to check whether a given number is positive or negative.

        public static void CheckInput()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            string result = num >= 0 ? $"Ther given number is Positive: {num}" : $"The given number is Negative: {num}";
            Console.WriteLine(result);
        }
    }
}
