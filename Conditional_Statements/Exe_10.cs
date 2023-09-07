using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Exe_10
    {
        //10. Write a C# Sharp program to determine the eligibility for admission
        //to a professional course based on the following criteria:
        //Marks in Maths >=65
        //Marks in Phy >=55
        //Marks in Chem>=50
        //Total in all three subject >=180
        //or
        //Total in Math and Subjects >=140


        public static void CheckEligibilityCriteria()
        {
            Console.WriteLine("Enter marks obtain in Physics");
            int phy_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks obtain in Chemistry");
            int che_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks obtain in Maths");
            int math_marks = int.Parse(Console.ReadLine());

            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", math_marks + phy_marks + che_marks);

            Console.Write("Total marks of Maths and  Physics : {0}\n", math_marks + phy_marks);

            if (math_marks >= 65)
                if (phy_marks >= 55)
                    if (che_marks >= 50)
                        if ((math_marks + phy_marks + che_marks) >= 180 || (math_marks + phy_marks) >= 140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");
        }
    }
}
