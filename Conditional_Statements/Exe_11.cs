using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_11
    {
        //11.Write a C# Sharp program to calculate the root of a quadratic equation.

        public static void FindRoot()
        {
            Console.WriteLine("Enter value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of c");
            int c = int.Parse(Console.ReadLine());

            //To calculate discriminant  D = b*b - 4ac
            int Disc = (b * b) - (4 * a * c);

            double x1;
            double x2;
            if(Disc > 0)
            {
                 x1 = (-b + Math.Sqrt(Disc) )/ (2 * a);
                 x2 = (-b - Math.Sqrt(Disc)) / (2 * a);
                Console.WriteLine($" X1 = {x1}, X2 = {x2} ");
            }
            else if(Disc == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / 2 * a;
                x2 = x1;

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            
        }
            else
            {
                Console.WriteLine("Root are imaginary");
                Console.WriteLine("No solution");
            }
        }
    }
}
