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
            for (int i = 0; i < args.Length; i++)
            {
                if (args.Length == 0)
                {
                    throw new ArgumentException("Error!Array cannot be null!");
                }
                else if (args[i].Length < 2)
                {
                    Console.WriteLine($"String's length less than 2. String number {i + 1} entered incorrectly");
                }
                else
                {
                    Console.WriteLine($"String {args[i]}:");
                    SubstringSeach.SearchMethod(args[i]);
                }                 
            }
            
        }
    }
}
