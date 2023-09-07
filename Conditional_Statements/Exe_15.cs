using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_15
    {
        //15. Write a C# Sharp program to check whether a triangle can be formed by the given angles value.

        public static void CheckInput()
        {
            Console.WriteLine("Enter side 1 of a triangle");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 2 of a triangle");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 3 of a triangle");
            int side3 = int.Parse(Console.ReadLine());

            int sumOfAllSides = side1 + side2 + side3;

            if(sumOfAllSides == 180)
            {
                Console.WriteLine("the triangle is valid");
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }
        }
    }
}
