using System;

namespace DEV_5
{
    /// <summary>
    /// Coordinate structure
    /// </summary>
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="x">The coordinates for the x.</param>
        /// <param name="y">The coordinates for the y.</param>
        /// <param name="z">The coordinates for the z.</param>
        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// The method calculates the distance between the old point and the new point.
        /// </summary>
        /// <param name="newPoint">New point.</param>
        /// <returns>Distance.</returns>
        public double GetDistance(Point newPoint)
        {
            return Math.Sqrt(Math.Pow(newPoint.X - this.X, 2) +
                            (Math.Pow(newPoint.Y - this.Y, 2)) +
                            (Math.Pow(newPoint.Z - this.Z, 2)));
        }
    }
}
