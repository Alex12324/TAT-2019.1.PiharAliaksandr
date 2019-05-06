using System;

namespace DEV_7
{
    /// <summary>
    /// Entry point class.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point function.
        /// </summary>
        /// <param name="args">Name of XML-file</param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("This XML file doesn't exist.");
                }
                XMLFileOfCars PassengerFile = new XMLFileOfCars(args[0]);
                XMLFileOfCars TruckFile = new XMLFileOfCars(args[1]);
                Client client = new Client(PassengerFile.autoShow,TruckFile.autoShow);
                Console.WriteLine("Enter the type of car :\n1)Passenger car\n2)Trucks");
                string type = Console.ReadLine().ToLower();
                if (type == "Passenger car".ToLower())
                {
                    PassengerFile.GettingInfoAndCreatingCar();
                    client.CommandResponses(PassengerFile.autoShow.Cars, client.ArrayOfCommandsForPassengerCars);
                }
                else if (type == "Trucks".ToLower()) 
                {
                    TruckFile.GettingInfoAndCreatingCar();
                    client.CommandResponses(TruckFile.autoShow.Cars,client.ArrayOfCommandsForTrucks);
                }
                else
                {
                    throw new Exception("This type doesn't exist. ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
