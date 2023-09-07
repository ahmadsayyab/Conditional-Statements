using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_6
    {
        //6. Write a C# Sharp program to read the value of an integer m
        //and display the value of n is 1 when m is larger than 0,
        //0 when m is 0 and -1 when m is less than 0.

        public static void CheckInput()
        {
            Console.WriteLine("Enter value of an integer");
            int m = int.Parse(Console.ReadLine());
            int n;

            if(m > 0 )
            {

                n = 1;
                Console.WriteLine($"the value of m = {m}");
                Console.WriteLine($"the value of n = {n}");
            }

            else if(m == 0)
            {
                n = 0;
                Console.WriteLine($"the value of m = {m}");
                Console.WriteLine($"the value of n = {n}");
            }
            else
            {
                n = -1;
                Console.WriteLine($"the value of m = {m}");
                Console.WriteLine($"the value of n = {n}");
            }
        }


    }
}
