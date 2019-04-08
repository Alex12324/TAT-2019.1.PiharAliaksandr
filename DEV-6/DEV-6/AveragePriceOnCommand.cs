
namespace DEV_6
{
    /// <summary>
    /// Child class for pattern command.
    /// </summary>
    class AveragePriceOnCommand : ICommand
    {
        AutoShow autoShow;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="autoShow"></param>
        public AveragePriceOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        /// <summary>
        /// Method calls AveragePrice function.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int Execute(string type = null)
        {
            return autoShow.AveragePriceCar(type);
        }
    }
}
