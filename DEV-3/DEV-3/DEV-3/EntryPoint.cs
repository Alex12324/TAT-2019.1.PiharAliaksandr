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
                List<int> list = new List<int>();
                Console.WriteLine("Select a criterion : ");
                int criterion = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your funds :");
                int amout = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the required efficiency :");
                int efficiency = Int32.Parse(Console.ReadLine());
                Company comp = new Company();
                if (criterion == 1)
                {
                    Recruitment obj = new FirstCriterion(amout);
                    list = comp.GetEmployee(obj);
                }
                else if (criterion == 2)
                {

                }
                else if (criterion == 3)
                {

                }
                else
                {
                    throw new Exception("This criterion doesn't exist.");
                }
                Console.WriteLine($"Lead : {list[0]}\nSenior : { list[1]}\n" +
                $"Middle : { list[2]}\nJunior : { list[3]}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
