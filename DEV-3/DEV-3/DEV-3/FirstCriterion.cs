using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class FirstCriterion : Recruitment
    {   
        public FirstCriterion(int Amout)
        {
            this.Amout = Amout;
        }
        /// <summary>
        /// This method counts the maximum productivity within the amount.
        /// </summary>
        public override List<int> Choose()
        {
            Junior objJunior = new Junior();
            Middle objMiddle = new Middle();
            Senior objSenior = new Senior();
            Lead objLead = new Lead();
            while (Amout > 0)
            {
                if (objLead.Salary < Amout)
                {
                    ListOfEmployee[0]++;
                    Amout -= objLead.Salary;
                }
                else if (objSenior.Salary < Amout)
                {
                    ListOfEmployee[1]++;
                    Amout -= objSenior.Salary;
                }
                else if (objMiddle.Salary < Amout)
                {
                    ListOfEmployee[2]++;
                    Amout -= objMiddle.Salary;
                }
                else if (objJunior.Salary < Amout)
                {
                    ListOfEmployee[3]++;
                    Amout -= objJunior.Salary;
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
