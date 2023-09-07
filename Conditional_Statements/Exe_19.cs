using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_19
    {
        //19. Write a program in C# Sharp to accept a grade and declare the equivalent description,

        public static void CheckGrade()
        {
            Console.WriteLine("a  ,e  ,v  ,g  ,f");
            Console.WriteLine("Choose grade from the above options");
            char input = char.Parse(Console.ReadLine());

            if(input == 'a')
            {
                Console.WriteLine("You have chosen: Average");
            }
            else if(input == 'e')
            {
                Console.WriteLine("You have chosen: Excellent");
            }
            else if(input == 'v')
            {
                Console.WriteLine("You have chosen: Very Good");
            }
            else if(input == 'g')
            {
                Console.WriteLine("You have chosen: Good");
            }
            else if(input == 'f')
            {
                Console.WriteLine("You have chosen: fail");
            }
            else
            {
                Console.WriteLine("Chose from the given option only");
            }
        }
    }
}
