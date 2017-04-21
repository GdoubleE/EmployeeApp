using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class EmployeeInput
    {
        
        public static void CollectHourlyInformation(Hourly theHourlyEmp)
            {
                theHourlyEmp.FirstName = InputUtilities.getStringInputValue("First Name");
                theHourlyEmp.LastName = InputUtilities.getStringInputValue("Last Name");
                theHourlyEmp.Gender = InputUtilities.getCharInputValue("Gender");
                theHourlyEmp.Dependents = InputUtilities.getIntegerInputValue("Dependents");
                theHourlyEmp.Wage = InputUtilities.getDoubleInputValue("Hourly Wage");
                theHourlyEmp.Hours = InputUtilities.getDoubleInputValue("Hours Worked");
                theHourlyEmp.Category = InputUtilities.getStringInputValue("Category: \n1 = temporary\n2 = part time\n3 =  full time");
                theHourlyEmp.Benefit.HealthInsuranceCompany = InputUtilities.getStringInputValue("Health Insurance Company");
                theHourlyEmp.Benefit.LifeInsuranceAmount = InputUtilities.getDoubleInputValue("Ammount of Life Insurance");
                theHourlyEmp.Benefit.VacationDays = InputUtilities.getIntegerInputValue("Number of Vacation Days");
            }
        public static void CollectSalariedInformation(Salaried theSalariedEmp)
            {
                theSalariedEmp.FirstName = InputUtilities.getStringInputValue("First Name");
                theSalariedEmp.LastName = InputUtilities.getStringInputValue("Last Name");
                theSalariedEmp.Gender = InputUtilities.getCharInputValue("Gender");
                theSalariedEmp.Dependents = InputUtilities.getIntegerInputValue("Dependents");
                theSalariedEmp.AnnualSalary = InputUtilities.getDoubleInputValue("Annual Salary");
                theSalariedEmp.ManagementLevel = InputUtilities.getIntegerInputValue("Management Level");
                theSalariedEmp.Benefit.HealthInsuranceCompany = InputUtilities.getStringInputValue("Health Insurance Company");
                theSalariedEmp.Benefit.LifeInsuranceAmount = InputUtilities.getDoubleInputValue("Ammount of Life Insurance");
                theSalariedEmp.Benefit.VacationDays = InputUtilities.getIntegerInputValue("Number of Vacation Days");
            }

    }
}
