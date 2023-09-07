using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_2
    {
        //2. Write a C# Sharp program to check whether a given number is even or odd.

        public static void CheckInput()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            string result = num % 2 == 0 ? "The given number is even" : "The given number is odd";

            Console.WriteLine(result);
        }
    }
}
