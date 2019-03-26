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
                Console.WriteLine(l);
                Console.WriteLine(l.text);
                Console.WriteLine(l.GetID());
                Presentation a = new Presentation("Matan", "PDF", "ccsv");
                Console.WriteLine(a);
                Console.WriteLine(a.URI);
                Console.WriteLine(a.GetID());
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
