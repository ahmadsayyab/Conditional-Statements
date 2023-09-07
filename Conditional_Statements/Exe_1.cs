using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Conditional_Statements
{
    internal class Exe_1
    {
        //1. Write a C# Sharp program to accept two integers
        //and check whether they are equal or not.

        public static void CheckInput()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());

               
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine("Number are different");
            }
        }
        
    }
}
