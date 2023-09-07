using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_12
    {
        //12. Write a C# Sharp program to read roll no,
        //name and marks of three subjects and calculate the total, percentage and division.

        public static void StdData()
        {
            Console.WriteLine("Enter your roll number");
            int rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Physics marks");
            int phy_marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks");
            int chem_marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Computer Application marks");
            int comp_marks = int.Parse(Console.ReadLine());

            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Marks in Physics: {phy_marks}");
            Console.WriteLine($"Marks in Chemistry: {chem_marks}");
            Console.WriteLine($"Marks in Computer Application: {comp_marks}");

            int total_Marks = phy_marks + chem_marks + comp_marks;
            Console.WriteLine($"Total Marks: {total_Marks}");

            double percentage = (total_Marks / 3);
            Console.WriteLine($"Percentage: {percentage}");

            string div;

            if (percentage >= 60)
            {
                div = "First";
            }
               
            else if (percentage < 60 && percentage >= 48)
            {
                div = "Second";
            }
               
            else if (percentage < 48 && percentage >= 36)
            {
                div = "Pass";
            }
                
            else
            {
                div = "Fail";
            }

            Console.WriteLine($"Division: {div}");
                
        }
    }
}
