using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_9
    {
        //9. Write a C# Sharp program to accept a coordinate point
        //in an XY coordinate system and determine in which quadrant the coordinate point lies.

        public static void FindCoordinate()
        {
            Console.WriteLine("Enter value for X Coordinate");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Y Coordinate");
            int Y = int.Parse(Console.ReadLine());

            if( X > 0 && Y > 0 )
            {
                Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the First quadrant.");
            }
            else if (X < 0 && Y >= 0)
            {
                Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Second quadrant.");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Third quadrant.");
            }
            else if(X > 0 && Y < 0) 
            {
                
                    Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Fourth quadrant.");
                
            }
            else
            {
                
                    Console.WriteLine($"The coordinate point ({X} , {Y}) lies at the origin.");
                
            }
        }
    }
}
