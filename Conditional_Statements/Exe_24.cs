using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_24
    {
        //24. Write a C# Sharp program that calculates
        //the area of geometrical shapes using a menu-driven approach.


        public static void CalcArea()
        {
            Console.WriteLine("Choose one from the below option to Calculate its area by entering its id" +
                "\n1.Circle \n2.Traingle \n3.Rectangle");

            int choose = int.Parse(Console.ReadLine());
            double area;
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter radius");
                    int radius = int.Parse(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    Console.WriteLine($"Area of a Circle: {area}");
                    break;
                case 2:
                    Console.WriteLine("Enter base value");
                    int base_val = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height value");
                    int height_val = int.Parse(Console.ReadLine()); 
                    area = (base_val * height_val * 0.5) ;
                    Console.WriteLine($"Area of a Triangle: {area}");
                    break;
                case 3:
                    Console.WriteLine("Enter lenght");
                    int len = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width");
                    int wid = int.Parse(Console.ReadLine());
                    area = len * wid;
                    Console.WriteLine($"Area of a Rectangle: {area}");
                    break;
                default:
                    Console.WriteLine("Choose only from the given three options");
                    break;
            }
        }
    }
}
