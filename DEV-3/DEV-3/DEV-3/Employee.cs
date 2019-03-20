using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My class Employee.
    /// </summary>
    abstract class Employee
    {
        public int Salary { get; protected set; } = 0;
        public int Productivity { get; protected set; } = 0;
    }
}
