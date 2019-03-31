using System;

namespace DEV_5
{   
    /// <summary>
    /// Class of my object bird.
    /// </summary>
    class Bird : IFlyable
    {
        public Point PointBird { get; set; }
        public int BirdSpeed;
        public double Distance { get; set; }
        public string ClassName
        {
            get
            {
                return GetType().Name;
            }
        }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="x">The coordinates for the x.</param>
        /// <param name="y">The coordinates for the y.</param>
        /// <param name="z">The coordinates for the z.</param>
        public Bird(int x = 0, int y = 0, int z = 0)
        {
            PointBird = new Point(x, y, z);
            BirdSpeed = new Random().Next(1, 20);
        }

        /// <summary>
        /// Method searchs distances and sets a new point for an object.
        /// </summary>
        /// <param name="newPoint">New point.</param>
        public void FlyTo(Point newPoint)
        {
            Distance += PointBird.GetDistance(newPoint);
            PointBird = newPoint;
        }

        /// <summary>
        /// The method calculates the flight time.
        /// </summary>
        /// <returns>Flight time.</returns>
        public double GetFlyTime() => Distance / BirdSpeed;

        /// <summary>
        /// The method returns the name of the object.
        /// </summary>
        /// <returns>Object name.</returns>
        public string WhoAmI() => ClassName;
    }
}
