using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    abstract class Recruitment
    {
        public int Amout { get; protected set; }
        public int Efficiency { get; protected set; }
        protected List<int> ListOfEmployee = new List<int>() { 0, 0, 0, 0 };
        public virtual List<int> Choose()
        {
            return new List<int>();
        }
    }
}
