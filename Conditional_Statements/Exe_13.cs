using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_13
    {
        //13. Write a C# Sharp program to read temperature in centigrade
        //and display a suitable message according to the temperature state below:
        //Temp < 0 then Freezing weather
        //Temp 0 - 10 then Very Cold weather
        //Temp 10 - 20 then Cold weather
        //Temp 20 - 30 then Normal in Temp
        //Temp 30 - 40 then Its Hot
        //Temp >= 40 then Its Very Hot


        public static void CheckTemp()
        {
            Console.WriteLine("Enter temperature value in centigrade");
            int temp_value = int.Parse(Console.ReadLine());

            if(temp_value < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp_value >= 0 && temp_value < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if(temp_value >= 10 && temp_value < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if(temp_value >= 20 && temp_value < 30)
            {
                Console.WriteLine("Normal weather");
            }
            else if(temp_value >= 30 && temp_value < 40)
            {
                Console.WriteLine("its Hot");
            }
            else
            { 
                Console.WriteLine("its very Hot");
            }
        }
    }
}
