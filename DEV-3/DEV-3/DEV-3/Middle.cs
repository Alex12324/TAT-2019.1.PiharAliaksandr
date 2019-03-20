using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My class Middle which inherited from Junior.
    /// </summary>
    class Middle : Junior
    {   
        public Middle()
        {
            Salary += 550;
            Productivity += 15;
        }
    }
}
