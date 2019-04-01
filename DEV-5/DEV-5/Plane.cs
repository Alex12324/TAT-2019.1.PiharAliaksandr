
namespace DEV_5
{
    /// <summary>
    /// Class of my object plane.
    /// </summary>
    class Plane : IFlyable
    {
        public Point PointPlane { get; set; }
        public int PlaneSpeed { get; set; } = 200;
        public double Distance { get; set; } = 0;
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
        public Plane(int x = 0, int y = 0, int z = 0) => PointPlane = new Point(x, y, z);

        /// <summary>
        /// The method sets a new point for an object and and varies the speed of the plane.
        /// </summary>
        /// <param name="newPoint">New point.</param>
        public void FlyTo(Point newPoint)
        {
            Distance += PointPlane.GetDistance(newPoint);
            PointPlane = newPoint;
            var time_distance = Distance;
            while (time_distance >= 10)
            {
                PlaneSpeed += 10;
                time_distance -= 10;
            }         
        }

        /// <summary>
        /// The method calculates the flight time.
        /// </summary>
        /// <returns>Flight time.</returns>
        public double GetFlyTime() => Distance / PlaneSpeed;

        /// <summary>
        /// The method returns the name of the object.
        /// </summary>
        /// <returns></returns>
        public string WhoAmI() => ClassName;
    }
}
