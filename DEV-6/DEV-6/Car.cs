
namespace DEV_6
{
    /// <summary>
    /// Class car.
    /// </summary>
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="count"></param>
        /// <param name="price"></param>
        public Car(string brand, string model, int count, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Count = count;
            this.Price = price;
        }   
    }
}
