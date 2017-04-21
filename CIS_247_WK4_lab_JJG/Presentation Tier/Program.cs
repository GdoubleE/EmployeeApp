using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //display system header
            ApplicationUtilities.DisplayApplicationInformation();

            // create an employee array with 4 positions to hold Employee information
            Employee[] employees = new Employee[4];
            
            ApplicationUtilities.DisplayDivider("Employee Type");  //call for employee type

            FillEmployeeArray(employees);  
            
            EmployeeOutput.DisplayNumberObject();
     

            ApplicationUtilities.PauseExecution();

                Console.ReadLine();

            
        }

        private static void FillEmployeeArray(Employee[] employees)
        {
            
            int count = 0;
            do
            {
                int typeIn = InputUtilities.getIntegerInputValue("Employee Type:    1:  for Salaried    2: for Hourly:    ");
                if (typeIn == 1)
                {
                    employees[count] = new Salaried();
                    ApplicationUtilities.DisplayDivider("Enter the Employee Information");
                    EmployeeInput.CollectSalariedInformation((Salaried)employees[count]);
                    EmployeeOutput.DisplayEmployeeInformation((Salaried)employees[count]);
                    ApplicationUtilities.DisplayDivider("Enter Next Employees information");
                    count++;  //Increment to next Index
                }
                else if (typeIn == 2)
                {
                    employees[count] = new Hourly();
                    ApplicationUtilities.DisplayDivider("\n============ Enter the Employee Information ================\n");
                    EmployeeInput.CollectHourlyInformation((Hourly)employees[count]);
                    EmployeeOutput.DisplayEmployeeInformation((Hourly)employees[count]);
                    ApplicationUtilities.DisplayDivider("------Enter Next Employees information----------");
                    count++;  //Increment to next Index
                }
                else
                {
                    Console.WriteLine("Thats not a valid Employee Type. Please try again");
                }
            } while (count < employees.Length);
        }

        
    }
}
