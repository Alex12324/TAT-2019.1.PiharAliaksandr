using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class SecondCriterion : Recruitment
    {
        public SecondCriterion(int Amount,int Efficiency)
        {
            this.Amount = Amount;
            this.Efficiency = Efficiency;
        }
        public override List<int> Choose()
        {
            while (Efficiency > 0)
            {
                while (Efficiency >= objMiddle.Productivity)
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
                    if (Efficiency >= objMiddle.Productivity && Amount >= objMiddle.Salary)
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
                if (Efficiency > 0 && Amount >= objJunior.Salary)
                {
                    Efficiency -= objJunior.Productivity;
                    ListOfEmployee[3]++;
                    Amount -= objJunior.Salary;
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
