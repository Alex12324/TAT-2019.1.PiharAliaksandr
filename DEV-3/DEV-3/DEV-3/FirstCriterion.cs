using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
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
                throw new Exception("Not enough money.");
            }
        }
        /// <summary>
        /// This method counts the maximum productivity within the amount.
        /// </summary>
        public override List<int> Choose()
        {
            while (Amount > 0)
            {
                if (objLead.Salary < Amount)
                {
                    ListOfEmployee[0]++;
                    Amount -= objLead.Salary;
                }
                else if (objSenior.Salary < Amount)
                {
                    ListOfEmployee[1]++;
                    Amount -= objSenior.Salary;
                }
                else if (objMiddle.Salary < Amount)
                {
                    ListOfEmployee[2]++;
                    Amount -= objMiddle.Salary;
                }
                else if (objJunior.Salary < Amount)
                {
                    ListOfEmployee[3]++;
                    Amount -= objJunior.Salary;
                }
                else
                {
                    break;
                }
            }
            return ListOfEmployee;
        }
    }
}
