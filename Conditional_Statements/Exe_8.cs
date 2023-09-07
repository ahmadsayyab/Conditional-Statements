using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_8
    {
        //8. Write a C# Sharp program to find the largest of three numbers.

        public static void FindLargestNum()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = int.Parse(Console.ReadLine());


            if(num1 != num2 && num2 != num3 && num3 != num1)
            {
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"The first number is the greatest among the three, i.e: {num1}");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"The Second number is the greatest among the three, i.e: {num2}");
                }
                else
                {
                    Console.WriteLine($"The third number is the greatest among the three, i.e: {num3}");
                }
            }
            else if(num1 == num2 && num3 < num1 && num3 < num2)
            {
                Console.WriteLine("num1 and num2 are equal");
            }
            else if(num1 == num2 && num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"The third number is the greatest among the three, i.e: {num3}");
            }
            else if (num1 == num3 && num2 < num1 && num2 < num3)
            {
                Console.WriteLine("num1 and num3 are equal");
            }
            else if (num1 == num3 && num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The Second number is the greatest among the three, i.e: {num2}");
            }
            else if (num2 == num3 && num1 < num2 && num1 < num3)
            {
                Console.WriteLine("num2 and num3 are equal");
            }
            else if (num2 == num3 && num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The first number is the greatest among the three, i.e: {num1}");
            }
            else
            {
                Console.WriteLine("The three numbers are equal");
            }




        }
    }
}
