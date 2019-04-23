using System;
using System.Xml;

namespace DEV_6
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
                if (args.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("This XML file doesn't exist.");
                }
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(args[0]);
                XMLFileOfCars reading = new XMLFileOfCars(xmlDocument);
                Client client = new Client(reading.autoShow);
                reading.GettingInfoAndCreatingCar();
                client.CommandResponses(reading.autoShow.Cars);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
