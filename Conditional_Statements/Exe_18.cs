using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_18
    {
        //18. Write a C# Sharp program to calculate and print the electricity bill of a customer.
        //From the keyboard,
        //the customer's name, ID, and unit consumed should be taken
        //and displayed along with the total amount due.



        public static void CalcBill()
        {
            Console.WriteLine("Enter your id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the amount of consumed units");
            int cons_units = int.Parse(Console.ReadLine());
            double chg_unit;
            double surchg = 0;

            if (cons_units < 200)
            {
                 chg_unit = 1.20;
            }
            else if (cons_units >= 200 && cons_units < 400)
            {
                chg_unit = 1.50;
            }
                
            else if (cons_units >= 400 && cons_units < 600)
            {
                chg_unit = 1.80;
            }
                
            else
            {
                chg_unit = 2.00;
            }
                
            double bill = cons_units * chg_unit;

            if (bill > 400)
            {
                surchg = bill * 15 / 100.0;
            }
                
            double total_amt = bill + surchg;
            if (total_amt < 100)
            {
                total_amt = 100;
            }
                

            Console.Write($"Customer IDNO                       :{id}\n");
            Console.Write($"Customer Name                       :{name}\n");
            Console.Write($"unit Consumed                       :{cons_units}\n");
            Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg_unit, bill);
            Console.Write("Surchage Amount                     :{0}\n", surchg);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", total_amt);
        }
    }
}
