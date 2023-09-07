using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_7
    {
        //7. Write a C# Sharp program to accept a person's height in centimeters
        //and categorize them according to their height.

        public static void CalcHeight()
        {
            Console.WriteLine("Enter your height in centimeters");
            int height = int.Parse(Console.ReadLine());

            if (height < 150.0)
            {
                Console.Write("The person is Dwarf. \n\n");
            }
                
            else if ((height >= 150.0) && (height <= 165.0))
            {
                Console.Write("The person is  average heighted. \n\n");
            }
                
            else if ((height >= 165.0) && (height <= 195.0))
            {
                Console.Write("The person is taller. \n\n");
            }
                
            else
            {
                Console.Write("Abnormal height.\n\n");
            }
                
        }
    }
}
