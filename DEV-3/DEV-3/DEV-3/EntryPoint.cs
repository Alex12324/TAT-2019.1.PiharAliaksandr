using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// My entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// My entry point function.
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            /// Junior(500,10),Middle(1050,25),Senior(1700,45),Lead(2450,70)
            try
            {
                Recruitment obj = new Recruitment(2400,0,1);
                obj.SearchMaxProductivity();
                obj.Display();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
