
namespace DEV_6
{
    /// <summary>
    /// Child class for pattern command.
    /// </summary>
    class CountAllOnCommand : ICommand
    {
        AutoShow autoShow;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="autoShow"></param>
        public CountAllOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        /// <summary>
        ///  Method calls CountAllCars function.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int Execute(string type = null)
        {
            return autoShow.CountAllCars(type);
        }
    }
}
