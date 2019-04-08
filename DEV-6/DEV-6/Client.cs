using System;
using System.Collections.Generic;

namespace DEV_6
{
    /// <summary>
    /// Class client.
    /// </summary>
    class Client
    {
        ICommand[] ArrayOfCommands;
        const string firstCommand = "count types";
        const string secondCommand = "count all";
        const string thirdCommand = "average price";

        /// <summary>
        /// The constructor of the class object whose commands appear
        /// </summary>
        /// <param name="autoShow"></param>
        public Client(AutoShow autoShow)
        {
            ArrayOfCommands = new ICommand[]
            {
                    new CountTypesOnCommand(autoShow),
                    new CountAllOnCommand(autoShow),
                    new AveragePriceOnCommand(autoShow),
                    new AveragePriceTypeOnCommand(autoShow)
            };
        }

        /// <summary>
        /// Request method
        /// </summary>
        /// <param name="Cars"></param>
        public void CommandResponses(List<Car> Cars)
        {
            Console.WriteLine("You have commands :\n1)count types\n2)count all\n3)average price\n4)average price <type>");
            Console.WriteLine("Enter command : ");
            string command = String.Empty;
            while ((command = Console.ReadLine().ToLower()) != "exit") 
            {
                if (command == "count types")
                {
                    Console.WriteLine(ArrayOfCommands[0].Execute(null));
                }
                else if (command == "count all")
                {
                    Console.WriteLine(ArrayOfCommands[1].Execute(null));
                }
                else if (command == "average price")
                {
                    Console.WriteLine(ArrayOfCommands[2].Execute(null));
                }
                else if (command.Contains("average price"))
                {
                    foreach (var car in Cars)
                    {
                        if (command.Contains(car.Brand.ToLower()))
                        {
                            Console.WriteLine(ArrayOfCommands[3].Execute(car.Brand));
                            break;
                        }
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
