using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Client
    {
        ICommand[] ArrayOfCommands;
        const string firstCommand = "count types";
        const string secondCommand = "count all";
        const string thirdCommand = "average price";

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

        public void CommandResponses()
        {
            Console.WriteLine("Enter command : ");
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "exit") 
            {
                switch (command)
                {
                    case firstCommand:
                        Console.WriteLine(ArrayOfCommands[0].Execute(null));
                        continue;
                    case secondCommand:
                        Console.WriteLine(ArrayOfCommands[1].Execute(null));
                        continue;
                    case thirdCommand:
                        Console.WriteLine(ArrayOfCommands[2].Execute(null));
                        continue;
                }
            } 
        }
    }
}
