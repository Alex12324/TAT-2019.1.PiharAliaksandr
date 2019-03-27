using System;

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
