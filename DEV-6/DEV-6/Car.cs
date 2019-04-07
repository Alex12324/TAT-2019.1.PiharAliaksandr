using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public Car(string brand, string model, int count, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Count = count;
            this.Price = price;
        }   
    }
}
