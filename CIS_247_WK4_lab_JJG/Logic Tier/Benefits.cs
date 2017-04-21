using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Benefits 
    {
        private const string DEFAULT_HEALTH_INSURANCE = "Blue Cross";
        private const double MIN_LIFE_INSURANCE = 0;
        private const double MAX_LIFE_INSURANCE = 1000000;
        private const int MIN_VACATION = 0;
        private const int MAX_VACATION = 45;

        private string healthInsuranceCompany;
        private double lifeInsuranceAmount;
        private int vacationDays;

        #region Constructors
        /// <summary>
        /// Default Constructor for Benefits
        /// </summary>
        public Benefits()
        {
            HealthInsuranceCompany = DEFAULT_HEALTH_INSURANCE;
            LifeInsuranceAmount = MIN_LIFE_INSURANCE;
            VacationDays = MIN_VACATION;
        }

       /// <summary>
       /// paramatarized constructor for Benefits
       /// constructs a new Benefits instance
       /// </summary>
       /// <param name="health">Health insurance provider</param>
       /// <param name="life">Life insurance amount</param>
       /// <param name="vacation">number of vacation days</param>
        public Benefits(string health, double life, int vacation)
        {
            HealthInsuranceCompany = health;
            LifeInsuranceAmount = life;
            VacationDays = vacation;
        }
        #endregion


        #region Properties
        public string HealthInsuranceCompany
        {
            get
            {
                return healthInsuranceCompany;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    healthInsuranceCompany = DEFAULT_HEALTH_INSURANCE;
                }
                else
                {
                    healthInsuranceCompany = value;
                }
            }
        }

        public double LifeInsuranceAmount   
        {
            get
            {
                return lifeInsuranceAmount;
            }
            set
            {
                if (value < MIN_LIFE_INSURANCE)
                {
                    lifeInsuranceAmount = MIN_LIFE_INSURANCE;
                }
                else if (value > MAX_LIFE_INSURANCE)
                {
                    lifeInsuranceAmount = MAX_LIFE_INSURANCE;
                }
                else
                {
                    lifeInsuranceAmount = value;
                }
            }
        }

        public int VacationDays
        {
            get
            {
                return vacationDays;
            }
            set
            {
                if (value <= MIN_VACATION) 
                {
                    vacationDays = MIN_VACATION;
                }
                else if (value >= MAX_VACATION)
                {
                    vacationDays = MAX_VACATION;
                }
                else
                {
                    vacationDays = value;
                }
            }
        }
        #endregion

        public override string ToString()
        {
            string output;

            output = "\n           ============== Benefit Information ==============              ";
            output += "\n              Insurance Company:                         " + healthInsuranceCompany;
            output += "\n              Life Insurance Ammount:                    " + lifeInsuranceAmount.ToString("C2");
            output += "\n              Number of Vacation Days:                   " + vacationDays;
            return output;
        }



    }
}
