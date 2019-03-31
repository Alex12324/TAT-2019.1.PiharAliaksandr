
namespace DEV_5
{
    class SpaceShip : IFlyable
    {
        public Point PointSpaceShip;
        public const int SpaceShipSpeed = 8000 * 3600;
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
        public SpaceShip(int x = 0, int y = 0, int z = 0) => PointSpaceShip = new Point(x, y, z);

        /// <summary>
        /// Method searchs distances and sets a new point for an object.
        /// </summary>
        /// <param name="newPoint">New point.</param>
        public void FlyTo(Point newPoint)
        {
            Distance = PointSpaceShip.GetDistance(newPoint);
            PointSpaceShip = newPoint;
        }

        /// <summary>
        /// The method calculates the flight time.
        /// </summary>
        /// <returns></returns>
        public double GetFlyTime() => Distance / SpaceShipSpeed;

        /// <summary>
        /// The method returns the name of the object.
        /// </summary>
        /// <returns></returns>
        public string WhoAmI() => ClassName;
    }
}
