using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_17
    {
        //17. Write a C# Sharp program to calculate profit and loss on a transaction.

        public static void CalcProfitAndLoss()
        {
            Console.WriteLine("Enter purchase price");
            int purchase_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sell price");
            int sell_price = int.Parse(Console.ReadLine());

            int plamt;
            if (sell_price > purchase_price)
            {
                plamt = sell_price - purchase_price;
                Console.Write($"You can booked your profit amount : {plamt}");
            }
            else if (purchase_price > sell_price)
            {
                plamt = purchase_price - sell_price;
                Console.Write($"You got a loss of amount : {plamt}");
            }
            else
            {
                Console.Write("You are running in no profit no loss condition");
            }
        }
    }
}
