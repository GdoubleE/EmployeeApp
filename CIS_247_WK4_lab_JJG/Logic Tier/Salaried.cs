using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Salaried : Employee
    {
        #region Attributes
        private const int MIN_MANAGEMENT_LEVEL = 0;
        private const int MAX_MANAGEMENT_LEVEL = 3;
        private const double BONUS_PERCENT = .10;
        private const double TAX_RATE = .73;

        private int managementLevel;
        #endregion

        #region Constructors
        public Salaried() :base("Salaried")
        {
        }

        public Salaried(string employeeType, string firstName, string lastName, char gender, int dependents, double annualSalary, Benefits benefits, int managementLevel,double netPay)
            : base("Salaried", firstName, lastName, gender, dependents, annualSalary, benefits)
                {
                    managementLevel = ManagementLevel;
                }
        #endregion

        #region Properties

        public int ManagementLevel
        {
            get
                {return managementLevel;}
            set
                {
                    if (value <= MIN_MANAGEMENT_LEVEL)
                        {
                            managementLevel = MIN_MANAGEMENT_LEVEL;
                        }
                    else if (value >= MAX_MANAGEMENT_LEVEL)
                        {
                            managementLevel = MAX_MANAGEMENT_LEVEL;
                        }
                    else
                        {
                            managementLevel = value;
                        }
                }
        }
        #endregion

        #region Calculations
        public double ActualBonusPercent()
            {
                return ManagementLevel * BONUS_PERCENT;
            }

        public override double CalculateWeeklyPay()
            {
                return (annualSalary*(1+ActualBonusPercent()))/52;
            }

        public override double CalculateNetPay()
            {
                return CalculateWeeklyPay() * TAX_RATE;
            }

        public override string ToString()
            {
                string output;
                output = base.ToString();
                output += "\n             Management Level:                     " + ManagementLevel;
                output += "\n             Percent Bonus:                        " + ActualBonusPercent().ToString("p1");
                output += benefit.ToString();
                return output;
            }
        #endregion


    }
    }

