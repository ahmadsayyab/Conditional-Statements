using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_5
    {
        //5. Write a C# Sharp program to read the age of a candidate
        //and determine whether it is eligible for casting his/her own vote.

        public static void CheckInput()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            string result = age >= 18 ? "Congratulation! You are eligible for casting your vote." : "you are not allowed to vote";
            Console.WriteLine(result);
        }
    }
}
