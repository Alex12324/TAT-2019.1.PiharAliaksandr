using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {   
        static void Main(string[] args)
        {
            try
            {
                Lectures l = new Lectures("Матанализ","vesjbhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhrbevebv");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
