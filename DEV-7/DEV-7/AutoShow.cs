using System.Collections.Generic;

namespace DEV_7
{
    /// <summary>
    /// Сlass showroom where my cars are stored.
    /// </summary>
    class AutoShow
    {
        public List<Car> Cars = new List<Car>();
        /// <summary>
        /// Method for counting the number of car brands.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int CountTypesCars(string type)
        {
            int CountOfTypes = 0;
            List<string> ListOfTypes = new List<string>();
            foreach (var car in Cars)
            {
                if (!ListOfTypes.Contains(car.Brand))
                {
                    CountOfTypes++;
                    ListOfTypes.Add(car.Brand);
                }
            }
            return CountOfTypes;
        }

        /// <summary>
        /// Method for counting the number of all cars
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int CountAllCars(string type)
        {
            int counter = 0;
            foreach (var count in Cars)
            {
                counter += count.Count;
            }
            return counter;
        }

        /// <summary>
        /// Method for calculating the average cost of cars.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method for calculating the average cost of cars by brand.
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public int AveragePriceTypeCar(string brand)
        {
            int AllPriceType = 0;
            int AllCarsType = 0;
            foreach (var car in Cars)
            {
                if (car.Brand == brand)
                {
                    AllPriceType += car.Price * car.Count;
                    AllCarsType += car.Count;
                }
            }
            return AllPriceType / AllCarsType;
        } 
    }
}
