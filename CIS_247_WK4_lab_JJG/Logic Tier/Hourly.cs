using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Hourly : Employee
    {
        #region Attributes
        private const double MIN_WAGE = 10;
        private const double MAX_WAGE = 75;
        private const double MIN_HOURS = 0;
        private const double MAX_HOURS = 50;
        private const double TAX_RATE = .82;

        private double wage;
        private double hours;
        private string category;
        #endregion

        #region Constructors
        public Hourly()
            : base("Hourly")
            {
                wage = Wage;
                hours = Hours;
                category = Category;
            }

        public Hourly(string employeeType, string firstName, string lastName, char gender, int dependents, double annualSalary, Benefits benefit, double wage, double hours, string category)
            : base("Hourly", firstName, lastName, gender, dependents, 0, benefit)
            {
                this.wage = wage;
                this.hours = Hours;
                this.category = category;
                this.netPay = netPay;
            }
        #endregion

        #region Properties
        public double Wage
        {
            get
            { return wage; }
            set
            {
                if (value <= MIN_WAGE)
                {
                    wage = MIN_WAGE;
                }
                else if (value >= MAX_WAGE)
                {
                    wage = MAX_WAGE;
                }
                else
                {
                    wage = value;
                }
                base.AnnualSalary = CalculateWeeklyPay() * 48;
            }
        }
        public double Hours
        {
            get
            { return hours; }
            set
            {
                if (value <= MIN_HOURS)
                {
                    hours = MIN_HOURS;
                }
                else if (value >= MAX_HOURS)
                {
                    hours = MAX_HOURS;
                }
                else
                {
                    hours = value;
                }
                base.AnnualSalary = CalculateWeeklyPay() * 48;
            }
        }

        public string Category
        {
            get
            { return category; }
            set
            {
                switch (value)
                {
                    case "1":
                        category = "temporary";
                        break;
                    case "2":
                        category = "part time";
                        break;
                    case "3":
                        category = "full time";
                        break;
                    default:
                        Console.WriteLine("please enter a valid number 1, 2, or 3");
                        break;
                }
            }
        }
        #endregion

        #region Calculation Methods

        public override double CalculateWeeklyPay()
            { 
                return wage * hours; 
            }

        public override double CalculateNetPay()
            {
                return CalculateWeeklyPay() * TAX_RATE;
            }

        public override string ToString()
            {
                string output;

                output = base.ToString();
                output += "\n           Employee Status:            " + category;
                output += "\n           Hourly Wage                 " + wage.ToString("C2");
                output += "\n           Hours Worked:               " + hours;
                output += benefit.ToString();
                return output;
            }

        
        #endregion
    }
}


