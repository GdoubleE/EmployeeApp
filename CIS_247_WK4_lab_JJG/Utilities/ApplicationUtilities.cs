using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    public class ApplicationUtilities
    {
        public static void DisplayApplicationInformation()
        {
            Console.WriteLine("Welcome the Basic Employee Program");
            Console.WriteLine("CIS247a, Week 6 ILab");
            Console.WriteLine("Name: Josh Gee");
            Console.WriteLine("This program creates and stores Employee objects; Hourly and Salaried in an array based on user input");
            Console.WriteLine();
        }
        public static void DisplayDivider(string outputTitle)
        {
            Console.WriteLine("\n********* " + outputTitle + " *********\n");
        }
        public static void TerminateApplication()
        {
            DisplayDivider("Program Termination");
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }
        public static void PauseExecution()
        {
            Console.Write("\nProgram paused, press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
