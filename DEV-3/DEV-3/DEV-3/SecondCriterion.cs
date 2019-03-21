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
            this.Amout = Amout;
            this.Efficiency = Efficiency;
        }
        public override List<int> Choose()
        {

            return ListOfEmployee;
        }
    }
}
