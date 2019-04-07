using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class CountAllOnCommand : ICommand
    {
        AutoShow autoShow;
        public CountAllOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        public int Execute(string type = null)
        {
            return autoShow.CountAllCars(type);
        }
    }
}
