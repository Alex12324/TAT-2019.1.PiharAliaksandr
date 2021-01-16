using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// This is the first criterion.Condition: maximum productivity within the amount.
    /// </summary>
    class FirstCriterion : Recruitment
    {   
        public FirstCriterion(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("You don't have money. ");
            }
        }
        /// <summary>
        /// This method counts the maximum productivity within the amount.
        /// </summary>
        /// <returns>List of number of employees to order.</returns>
        public override List<int> Choose()
        {
            while (Amount > 0)
            {
                if (objLead.Salary < Amount)
                {
                    ListOfEmployee[0]++;
                    Amount -= objLead.Salary;
                    Efficiency += objLead.Productivity;
                }
                else if (objSenior.Salary < Amount)
                {
                    ListOfEmployee[1]++;
                    Amount -= objSenior.Salary;
                    Efficiency += objSenior.Productivity;
                }
                else if (objMiddle.Salary < Amount)
                {
                    ListOfEmployee[2]++;
                    Amount -= objMiddle.Salary;
                    Efficiency += objMiddle.Productivity;
                }
                else if (objJunior.Salary < Amount)
                {
                    ListOfEmployee[3]++;
                    Amount -= objJunior.Salary;
                    Efficiency += objJunior.Productivity;
                }
                else
                {
                    break;
                }
            }
            if (Efficiency == 0)
            {
                throw new Exception("You don't have enough money to hire any employee. ");
            }
            else
            {
                return ListOfEmployee;
            } 
        }
    }
}
