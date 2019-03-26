using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
