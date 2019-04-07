using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class CountTypesOnCommand : ICommand
    {
        AutoShow autoShow;
        public CountTypesOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        public int Execute(string type = null)
        {
            return autoShow.CountTypesCars(type);
        }
    }
}
