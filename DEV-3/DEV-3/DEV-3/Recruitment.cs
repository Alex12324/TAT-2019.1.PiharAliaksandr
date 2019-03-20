using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// This class selects personnel according to the criteria.
    /// </summary>
    class Recruitment : Employee
    {
        private int Amout;
        private int Efficiency;
        private int Criterion;
        private List<int> ListOfEmployee = new List<int> { 0, 0, 0, 0 };
        public Recruitment(int Amout,int Efficiency,int Criterion)
        {
            if (Amout > 0)
            {
                this.Amout = Amout;
                this.Efficiency = Efficiency;
                this.Criterion = Criterion;
            }
            else
            {
                throw new ArgumentException("Incorrect amount entered");
            }
        }

        /// <summary>
        ///This method calls the recruitment functions according to the selected criterion. 
        /// </summary>
        public void CriteriaSelection()
        {
            if (Criterion == 1)
            {
                SearchMaxProductivity();
            }
            else if (Criterion == 2)
            {

            }
            else if (Criterion == 3)
            {

            }
            else
            {
                Console.WriteLine("This criterion doesn't exist.");
            }               
        }
        /// <summary>
        /// This method counts the maximum productivity within the amount.
        /// </summary>
        public void SearchMaxProductivity()
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
        }
        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Lead : {ListOfEmployee[0]}\nSenior : { ListOfEmployee[1]}\n" +
                $"Middle : { ListOfEmployee[2]}\nJunior : { ListOfEmployee[3]}");
        }
    }
}
