using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1
{   /// <summary>
    /// This class is searched for substrings.
    /// </summary>
    class SubstringSeacher
    {   
        /// <summary>
        /// This constructor checks for the correct entered string.
        /// </summary>
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
        /// <summary>
        /// The method realized which displays all the substrings(two and more symbols),
        /// where there are no any two subsequent repeated symbols.
        /// </summary>
        /// <returns>List of strings</returns>
        public List<string> SearchSubsequent()
        {
            List<string> ListOfSubstrings = new List<string>();
            for (int i = 0; i < substring.Length - 1; i++)
            {
                StringBuilder mainString = new StringBuilder();
                mainString.Append(substring[i].ToString());
                for (int j = i; j < substring.Length - 1; j++)
                {
                    if (substring[j] != substring[j + 1])
                    {
                        mainString.Append(substring[j + 1]);
                    }
                    else
                    {
                        break;
                    }
                    if (!ListOfSubstrings.Contains(mainString.ToString()) && mainString.Length > 1)
                    {
                        ListOfSubstrings.Add(mainString.ToString());
                    }
                }
            }
            return ListOfSubstrings;
        }
        /// <summary>
        /// This method displays substrings(two and more symbols),
        /// where there are no any two subsequent repeated symbols.
        /// </summary>
        /// <param name="ListOfSubstrings">List of my strings</param>
        public void DisplaysSubsequent(List<string> ListOfSubstrings)
        {
            foreach(var elements in ListOfSubstrings)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
