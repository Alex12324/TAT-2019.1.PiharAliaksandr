using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    throw new ArgumentOutOfRangeException("This XML file doesn't exist.");
                }
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(args[0]);
                XMLFileOfCars reading = new XMLFileOfCars(xmlDocument);
                Client client = new Client(reading.autoShow);
                reading.GettingInfoAndCreatingCar();
                client.CommandResponses();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
