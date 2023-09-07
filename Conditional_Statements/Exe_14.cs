using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_14
    {
        //14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.


        public static void CheckTraingle()
        {
            Console.WriteLine("Enter side 1 of a traingle");
            int val_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 2 of a traingle");
            int val_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 3 of a traingle");
            int val_3 = int.Parse(Console.ReadLine());


            if(val_1 == val_2 && val_2 == val_3)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if(val_1 == val_2 || val_1 == val_3 || val_2 == val_3)
            {
                Console.WriteLine("This is a Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is an Scalene triangle ");
            }
        }
    }
}
