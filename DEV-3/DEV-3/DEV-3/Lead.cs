using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My class Lead which inherited from Senior.
    /// </summary>
    class Lead : Senior
    {   
        public Lead()
        {
            Salary += 750;
            Productivity += 25;
        }
    }
}
