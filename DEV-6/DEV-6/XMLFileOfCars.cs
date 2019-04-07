using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DEV_6
{
    class XMLFileOfCars
    {
        XmlDocument CarsInfo { get; }
        public AutoShow autoShow;

        public XMLFileOfCars(XmlDocument CarsInfo)
        {
            this.CarsInfo = CarsInfo;
            autoShow = new AutoShow();
        }

        public void GettingInfoAndCreatingCar()
        {
            XmlElement xRoot = CarsInfo?.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                string Brand = String.Empty;
                string Model = String.Empty;
                int Count = 0;
                int Price = 0;
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "brand")
                    {
                        Brand = child.InnerText;
                    }
                    if (child.Name == "model")
                    {
                        Model = child.InnerText;
                    }
                    if (child.Name == "count")
                    {
                        Count = Int32.Parse(child.InnerText);
                    }
                    if (child.Name == "price")
                    {
                        Price = Int32.Parse(child.InnerText);
                    }
                }
                if (Brand != null && Model != null && Price != 0 && Count != 0)
                {
                    autoShow.Cars.Add(new Car(Brand, Model, Count, Price));
                }
            }
        }
    }
}
