
namespace DEV_7
{
    /// <summary>
    /// Child class for pattern command. 
    /// </summary>
    class CountTypesOnCommand : ICommand
    {
        AutoShow autoShow;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="autoShow"></param>
        public CountTypesOnCommand(AutoShow autoShow)
        {
            this.autoShow = autoShow;
        }

        /// <summary>
        /// Method calls CountTypesCars function.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int Execute(string type = null)
        {
            return autoShow.CountTypesCars(type);
        }
    }
}
