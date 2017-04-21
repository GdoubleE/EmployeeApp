using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    abstract class Employee
    {
        #region Attributes and Default Values
        private const int MAX_DEPENDENTS = 10;
        private const int MIN_DEPENDENTS = 0;
        private const double MIN_SALARY = 20000d;
        private const double MAX_SALARY = 1000000d;
        private const string DEFAULT_NAME = "not given";
        private const char DEFAULT_GENDER = 'U';

        protected string firstName;
        protected string lastName;
        protected char gender;
        protected int dependents;
        protected double annualSalary;
        protected Benefits benefit;
        protected string employeeType;
        protected double netPay;

        protected static int numEmployees = 0;
        #endregion

        public string EmployeeType
        {
            get { return employeeType; }
        }

        public Benefits Benefit
        {
            get
            {return benefit;}
            set
            {
                if (benefit == null)
                {benefit = new Benefits();}
                else
                {benefit = value;}
            }
        }

 
        public Employee(string employeeType):this()
        {
            this.employeeType = employeeType;
        }

        public Employee()
        {
            firstName = FirstName;
            lastName = LastName;
            gender = Gender;
            dependents = Dependents;
            annualSalary = AnnualSalary;
            Benefit = new Benefits();
            Employee.numEmployees++;
        }

        public Employee(string employeeType, string firstName, string lastName, char gender, int dependents, double annualSalary, Benefits Benefit)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dependents = dependents;
            this.annualSalary = annualSalary;
            this.benefit = Benefit;
            
            this.employeeType = employeeType;
            Employee.numEmployees++;
        }

        #region Properties
        public string FirstName
        {
            get{return firstName;}
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    firstName = DEFAULT_NAME;
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    lastName = DEFAULT_NAME;
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public int Dependents
        {
            get
            {
                return dependents;
            }
            set
            {
                if (value <= MIN_DEPENDENTS)
                {
                    dependents = MIN_DEPENDENTS;
                }
                else if (value >=MAX_DEPENDENTS)
                {
                        dependents = MAX_DEPENDENTS;
                }
                else
                {
                    dependents = value;
                }
            }
        }

        public double AnnualSalary
        {
            get{return annualSalary;}
            set
            {
                if (value < MIN_SALARY)
                {
                    annualSalary = MIN_SALARY;
                }
                else if (value > MAX_SALARY)
                {
                    annualSalary = MAX_SALARY;
                } 
                else
                {
                    annualSalary = value;
                }
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                switch (value)
                {
                    case 'M':
                    case 'm':
                    case 'F':
                    case 'f':
                        gender = value;
                        break;
                    default:
                        gender = DEFAULT_GENDER;
                        break;
                }
            }
        }
        #endregion
        public static int NumberOfEmployees
        {
            get{return numEmployees;}
        }

        virtual public double CalculateWeeklyPay()
            {
                return annualSalary / 52;
            }

        abstract public double CalculateNetPay();
            
       
        public override string ToString()
        {
            string output;
            output = "\n====================== Employee Information =======================";
            output += "\n           Employee Type:              " + employeeType;
            output += "\n           Name:                       " + firstName + " " + lastName;
            output += "\n           Gender:                     " + gender;
            output += "\n           # of Dependents:            " + dependents;
            output += "\n           Annual Salary:              " + annualSalary.ToString("C2");
            output += "\n           Weekly Pay:                 " + CalculateWeeklyPay().ToString("C2");
            output += "\n           Net Pay:                    " + CalculateNetPay().ToString("C2");
            return output;
        } 
    }
}
