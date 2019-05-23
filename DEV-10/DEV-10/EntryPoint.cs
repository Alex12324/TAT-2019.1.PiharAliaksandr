using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.IO;

namespace DEV_10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                var shop = new Shop();
                shop.ReadDatabase();
                foreach (var item in shop.ProductsList)
                {
                    item.DisplayInfo();
                }

                //shop.DispalySelectedInfo();
                //shop.WriteToXml();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
