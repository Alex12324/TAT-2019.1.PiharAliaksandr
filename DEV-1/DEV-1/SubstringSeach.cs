using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{   /// <summary>
    /// In the class there is a method realized which displays all the substrings(two and more symbols),
    /// where there are no any two subsequent repeated symbols.
    /// </summary>
    public class SubstringSeach
    {
        public static void SearchMethod(string substring)
        {
            List<string> ListOfSubstrings = new List<string>();
            for (int i = 0; i < substring.Length - 1; i++)
            {
                string mainString = substring[i].ToString();
                for (int j = i; j < substring.Length - 1; j++)
                {
                    if (substring[j] != substring[j + 1])
                    {
                        mainString += substring[j + 1];
                    }
                    else
                    {
                        mainString = null;
                        break;
                    }
                    if (!ListOfSubstrings.Contains(mainString) && mainString.Length > 1)
                    {
                        ListOfSubstrings.Add(mainString);
                    }
                }
            }
            foreach (var elements in ListOfSubstrings)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
