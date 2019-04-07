using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class AveragePriceTypeOnCommand : ICommand
    {
        AutoShow autoShow;
        public AveragePriceTypeOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        public int Execute(string type)
        {
            return autoShow.AveragePriceTypeCar(type);
        }
    }
}
