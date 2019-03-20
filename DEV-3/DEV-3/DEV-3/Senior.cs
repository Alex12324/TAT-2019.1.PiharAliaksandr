using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My class Senior which inherited from Middle.
    /// </summary>
    class Senior : Middle
    {
        public Senior()
        {
            Salary += 650;
            Productivity += 20;
        }
    }
}
