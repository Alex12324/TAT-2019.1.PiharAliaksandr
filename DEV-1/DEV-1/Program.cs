using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{   /// <summary>
    /// Program which realized method SearchMethod.
    /// /// <param name="args">Arguments from command line</param>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0].Length < 2)
            {
                throw new ArgumentException("Cannot be less than 2!");
            }
            SubstringSeach.SearchMethod(args[0]);
        }
    }
}
