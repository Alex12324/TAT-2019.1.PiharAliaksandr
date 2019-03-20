using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My class Junior which inherited from Employee.
    /// </summary>
    class Junior : Employee
    {   
        
        public Junior()
        {
            Salary += 500;
            Productivity += 10;
        }
    }
}
