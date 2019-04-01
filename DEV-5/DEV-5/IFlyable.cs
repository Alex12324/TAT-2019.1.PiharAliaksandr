
namespace DEV_5
{
    /// <summary>
    /// Interface for objects that can fly.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// The method sets a new point for an object.
        /// </summary>
        /// <param name="newPoint">New point.</param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// The method calculates the flight time.
        /// </summary>
        /// <returns>Flight time.</returns>
        double GetFlyTime();

        /// <summary>
        /// The method returns the name of the object.
        /// </summary>
        /// <returns></returns>
        string WhoAmI();
    }
}
