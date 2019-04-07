using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class AveragePriceOnCommand : ICommand
    {
        AutoShow autoShow;
        public AveragePriceOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        public int Execute(string type = null)
        {
            return autoShow.AveragePriceCar(type);
        }
    }
}
