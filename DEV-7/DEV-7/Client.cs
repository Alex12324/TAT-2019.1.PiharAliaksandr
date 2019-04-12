using System;
using System.Collections.Generic;

namespace DEV_7
{
    /// <summary>
    /// Class client.
    /// </summary>
    class Client
    {
        public ICommand[] ArrayOfCommandsForPassengerCars;
        public ICommand[] ArrayOfCommandsForTrucks;

        /// <summary>
        /// The constructor of the class object whose commands appear
        /// </summary>
        /// <param name="passengerAutoShow"></param>
        public Client(AutoShow passengerAutoShow, AutoShow truckAutoShow)
        {
            ArrayOfCommandsForPassengerCars = new ICommand[]
            {
                    new CountTypesOnCommand(passengerAutoShow),
                    new CountAllOnCommand(passengerAutoShow),
                    new AveragePriceOnCommand(passengerAutoShow),
                    new AveragePriceTypeOnCommand(passengerAutoShow)
            };
            ArrayOfCommandsForTrucks = new ICommand[]
            {
                    new CountTypesOnCommand(truckAutoShow),
                    new CountAllOnCommand(truckAutoShow),
                    new AveragePriceOnCommand(truckAutoShow),
                    new AveragePriceTypeOnCommand(truckAutoShow)
            };
        }

        /// <summary>
        /// Request method.
        /// </summary>
        /// <param name="Cars"></param>
        public void CommandResponses(List<Car> Cars, ICommand[] commands)
        {
            Console.WriteLine("You have commands :\n1)count_types \n2)count_all \n" +
                              "3)average_price \n4)average_price type");
            Console.WriteLine("Enter command : ");
            string command = String.Empty;
            while ((command = Console.ReadLine().ToLower()) != "exit")
            {   
                if (command == "count_types")
                {
                    Console.WriteLine(commands[0].Execute(null));
                }
                else if (command == "count_all")
                {
                    Console.WriteLine(commands[1].Execute(null));
                }
                else if (command == "average_price")
                {
                    Console.WriteLine(commands[2].Execute(null));
                }
                else if (command.Contains("average_price"))
                {
                    foreach (var car in Cars)
                    {
                        if (command.Contains(car.Brand.ToLower()))
                        {
                            Console.WriteLine(commands[3].Execute(car.Brand));
                            break;
                        }
                    }
                }
                else if (command == "execute")
                {
                    for (int i = 0; i < commands.Length - 1; i++) 
                    {
                        Console.WriteLine(commands[i].Execute(null));
                    }
                }
                else
                {
                    Console.WriteLine("This command does not exist. Please enter from the suggested list. ");
                }
            }
        }
    }
}
