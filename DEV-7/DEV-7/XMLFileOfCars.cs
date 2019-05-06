using System;
using System.Xml.Linq;

namespace DEV_7
{
    /// <summary>
    /// A class that retrieves machine information from an XML file.
    /// </summary>
    class XMLFileOfCars
    {
        XDocument CarsInfo { get; }
        public AutoShow autoShow;
        private static XMLFileOfCars _instance;

        /// <summary>
        /// Singlton pattern.
        /// </summary>
        /// <param name="fileName">Filename</param>
        /// <returns></returns>
        public static XMLFileOfCars getInstance(string fileName)
        {
            if (_instance == null)
            {
                _instance = new XMLFileOfCars(fileName);
            }

            return _instance;
        }

        /// <summary>
        /// Initializing the xml document and creating a showroom for these machines.
        /// </summary>
        /// <param name="CarsInfo"></param>
        public XMLFileOfCars(string xmlFile)
        {
            CarsInfo = XDocument.Load(xmlFile);
            autoShow = new AutoShow();
        }

        /// <summary>
        /// A method that takes information from an xml file and creates a machine object.
        /// </summary>
        public void GettingInfoAndCreatingCar()
        {
            foreach (XElement carElement in CarsInfo.Element("cars").Elements("car"))
            {
                XElement brandElement = carElement.Element("brand");
                XElement modelElement = carElement.Element("model");
                XElement childElement = carElement.Element("count");
                XElement priceElement = carElement.Element("price");
                if (brandElement != null && modelElement != null && childElement != null && priceElement != null)
                {
                    autoShow.Cars.Add(new Car(brandElement.Value, modelElement.Value,
                                          Convert.ToInt32(childElement.Value), Convert.ToInt32(priceElement.Value)));
                }
            }
        }
    }
}
