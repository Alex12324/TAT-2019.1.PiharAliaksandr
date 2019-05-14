using System;

namespace DEV_2
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
            try
            {
                /*PhoneticConverter elem = new PhoneticConverter("молоко+");
                elem.Converter();
                var stringg = elem.NewStringMaker();*/
                var receivedString = new PhoneticConverter("молоко+");
                var actualString = receivedString.Converter();
                Console.WriteLine(actualString);
                Console.WriteLine(actualString.Equals("малако"));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error! String is empty!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something wrong!" + ex.Message);
            }
        }
    }
}
