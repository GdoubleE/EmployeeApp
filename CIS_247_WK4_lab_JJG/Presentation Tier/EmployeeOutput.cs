using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class EmployeeOutput
    {
        public static void DisplayEmployeeInformation(Hourly theHourlyEmployee)
            {
                Console.WriteLine(theHourlyEmployee.ToString());
            }
        public static void DisplayEmployeeInformation(Salaried theSalariedEmployee)
            {
                Console.WriteLine(theSalariedEmployee.ToString());
            }
        public static void DisplayNumberObject()
            {
                Console.WriteLine("-----------There were {0} Salaried Employees Created----------------",Salaried.NumberOfEmployees);
                Console.WriteLine("-----------And {0} Hourly Employees Created--------------", Hourly.NumberOfEmployees);
            }
    }
}
