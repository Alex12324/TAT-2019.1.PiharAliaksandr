using System;

namespace DEV_4
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {   
        /// <summary>
        /// Entry point function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                ///Here you can define the discipline which will include lectures, seminars, laboratory classes.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
