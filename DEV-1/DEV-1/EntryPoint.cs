using System;

namespace DEV_1
{   /// <summary>
    /// Program which realized method SearchMethod.
    /// /// <param name="args">Arguments from command line</param>
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                SubstringSeacher obj = new SubstringSeacher(args[0]);
                obj.DisplaysSubsequent(obj.SearchSubsequent());
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error!Array cannot be empty!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }
    }
}
