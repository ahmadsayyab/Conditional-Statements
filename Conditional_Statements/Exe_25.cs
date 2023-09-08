using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_25
    {
        //25. Write a program in C# Sharp which is a menu-driven program to perform simple calculations.

        

        public static void PerformOpr()
        {
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());

            
                Console.WriteLine("Choose by id the operation you want to perform on these 2 numbers" +
               "\n1.addition \n2.Subtraction \n3.Multiplication \n4.Division \n5.Exit");

                int choice = int.Parse(Console.ReadLine());
                double result;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Addition: {result}");
                        break;
                    case 2:
                        result = num2 - num1;
                        Console.WriteLine($"Subtraction: {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Multiplication: {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero is not possible");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Division: {result}");
                        }

                        break;
                    case 5:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Choose only from the given option");
                        break;
                }
            }

        }




    }
}
