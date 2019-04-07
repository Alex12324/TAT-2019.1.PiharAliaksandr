using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class AutoShow
    {
        public List<Car> Cars = new List<Car>();

        public int CountTypesCars(string type)
        {
            int CountOfTypes = 0;
            List<string> ListOfTypes = new List<string>();
            foreach (var car in Cars)
            {
                if (!ListOfTypes.Contains(car.Model))
                {
                    CountOfTypes++;
                    ListOfTypes.Add(car.Model);
                }
            }
            return CountOfTypes;
        }

        public int CountAllCars(string type)
        {
            int counter = 0;
            foreach (var count in Cars)
            {
                counter += count.Count;
            }
            return counter;
        }

        public int AveragePriceCar(string type)
        {
            int AllPrice = 0;
            int AllCars = 0;
            foreach (var car in Cars)
            {
                AllPrice += car.Price * car.Count;
                AllCars += car.Count;
            }
            return (int)(AllPrice / AllCars);
        }

        public int AveragePriceTypeCar(string brand)
        {
            int AllPriceType = 0;
            int AllCarsType = 0;
            foreach (var car in Cars)
            {
                if (car.Brand == brand)
                {
                    AllPriceType += car.Price;
                    AllCarsType += car.Count;
                }
            }
            return AllPriceType / AllCarsType;
        }

    }
}
