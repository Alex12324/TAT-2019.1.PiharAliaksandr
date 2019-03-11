using System;
using System.Collections.Generic;

namespace DEV_1
{   /// <summary>
    /// In the class there is a method realized which displays all the substrings(two and more symbols),
    /// where there are no any two subsequent repeated symbols.
    /// </summary>
    class SubstringSeacher
    {
        private string substring;
        public SubstringSeacher(string test_string)
        {   
            if (test_string.Length < 2)
            {
                throw new FormatException("String's length less than 2");
            }
            else
            {
                substring = test_string;
            }

        }
        public List<string> SearchSubsequent()
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
                        break;
                    }
                    if (!ListOfSubstrings.Contains(mainString) && mainString.Length > 1)
                    {
                        ListOfSubstrings.Add(mainString);
                    }
                }
            }
            return ListOfSubstrings;
        }
        public void DisplaysSubsequent(List<string> ListOfSubstrings)
        {
            foreach(var elements in ListOfSubstrings)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
