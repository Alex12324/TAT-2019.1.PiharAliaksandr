using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// The class that is used to display information.
    /// </summary>
    class Display
    {
        public void DisplaysList(List<int> list)
        {
            Console.WriteLine($"Lead : {list[0]}\nSenior : { list[1]}\n" +
                $"Middle : { list[2]}\nJunior : { list[3]}");
        }
    }
}
