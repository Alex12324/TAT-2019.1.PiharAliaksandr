using System;
using System.Collections.Generic;

namespace DEV_5
{   
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {   
        /// <summary>
        /// Entry point function.
        /// </summary>
        static void Main()
        {
            try
            {
                List<IFlyable> ListOfFlying = new List<IFlyable>() { new Bird(), new Plane(), new SpaceShip() };
                foreach (var el in ListOfFlying)
                {
                    el.FlyTo(new Point(100, 200, 800));
                    Console.WriteLine(el.WhoAmI());
                    Console.WriteLine(el.GetFlyTime()); //Time is measured in hours.
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message} ");
            }
        }
    }
}
