using System;

namespace DEV_4
{
    /// <summary>
    /// Extention method for all string objects.
    /// </summary>
    static class StringExpansion
    {
        public static string GetID(this string str)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
