using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    interface ICommand
    {
        int Execute(string type);
    }
}
