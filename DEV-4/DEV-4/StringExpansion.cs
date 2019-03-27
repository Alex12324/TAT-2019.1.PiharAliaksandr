using System;

namespace DEV_4
{
    static class StringExpansion
    {
        public static string GetID(this string str)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
