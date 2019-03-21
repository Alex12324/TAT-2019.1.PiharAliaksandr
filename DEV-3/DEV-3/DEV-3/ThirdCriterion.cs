using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// This is the third criterion. Condition : The minimum number of staff qualifications above Junior for a fixed productivity.
    /// </summary>
    class ThirdCriterion : Recruitment
    {
        public ThirdCriterion(int Amount,int Efficiency)
        {
            if (Amount < 0)
            {
                throw new Exception("You don't have money. ");
            }
            else
            {
                this.Amount = Amount;
                this.Efficiency = Efficiency;
            }
        }
        /// <summary>
        /// Method which realizes this criterion.
        /// </summary>
        /// <returns>List of number of employees to order.</returns>
        public override List<int> Choose()
        {
            while (Efficiency > 0)
            {
                while (Efficiency >= objSenior.Productivity)
                {
                    while (Efficiency >= objLead.Productivity)
                    {
                        if (Efficiency >= objLead.Productivity && Amount >= objLead.Salary)
                        {
                            Efficiency -= objLead.Productivity;
                            ListOfEmployee[0]++;
                            Amount -= objLead.Salary;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (Efficiency >= objSenior.Productivity && Amount >= objSenior.Salary)
                    {
                        Efficiency -= objSenior.Productivity;
                        ListOfEmployee[1]++;
                        Amount -= objSenior.Salary;
                    }
                    else
                    {
                        break;
                    }
                }
                if (Efficiency >= 0 && Amount >= objMiddle.Salary)
                {
                    Efficiency -= objMiddle.Productivity;
                    ListOfEmployee[2]++;
                    Amount -= objMiddle.Salary;
                }
                else
                {
                    break;
                }
            }
            if (Amount < 0 || Efficiency > 0)
            {
                throw new Exception("You don't have enough money for this order. ");
            }
            else
            {
                return ListOfEmployee;
            }
        }
    }
}
