
namespace DEV_6
{
    /// <summary>
    /// Child class for pattern command.
    /// </summary>
    class AveragePriceTypeOnCommand : ICommand
    {
        AutoShow autoShow;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="autoShow"></param>
        public AveragePriceTypeOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        /// <summary>
        /// Method calls AveragePriceTypeCar function.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int Execute(string type)
        {
            return autoShow.AveragePriceTypeCar(type);
        }
    }
}
