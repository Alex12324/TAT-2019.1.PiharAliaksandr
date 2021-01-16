using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// This class selects personnel according to the criteria.
    /// </summary>
    class Company
    {
        public List<int> GetEmployee(Recruitment rec)
        {
            return rec.Choose();
        }
    }
}
