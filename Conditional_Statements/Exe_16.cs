using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_16
    {
        //16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.

        public static void CheckInput()
        {
            Console.WriteLine("Enter an alphabet");
            char input = char.Parse(Console.ReadLine());

            if(input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("The alphabet is a vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is consonant");
            }
        }
    }
}
