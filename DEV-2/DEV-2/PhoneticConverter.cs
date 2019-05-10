using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// In this class phonetic parsing of the word is performed.
    /// </summary>
    public class PhoneticConverter
    {
        private string word;
        private StringBuilder newString = new StringBuilder();
        private readonly List<Letters> ListOfLetters = new List<Letters>();
        private readonly List<string> ListOfVowels = new List<string> { "а", "о", "и", "е", "ё", "э",
            "ы", "у", "ю", "я" };
        private readonly List<string> ListOfConsonants = new List<string> { "б", "в", "г", "д", "й", "ж",
            "з", "к", "л", "м", "н","п", "р", "с", "т", "ф", "х", "ц", "ч", "ш", "щ" };
        private readonly List<string> ListOfDeaf = new List<string> { "п", "ф", "к", "с", "т",
            "ш","ч", "щ", "ц","х" };
        private readonly List<string> ListOfRinging = new List<string> { "б", "в", "г", "з", "д", "ж" };
        private readonly KeyValuePair<string, string>[] SoftVowels = new KeyValuePair<string, string>[]
        {
            new KeyValuePair<string, string>("ю", "'у"),
            new KeyValuePair<string, string>("я", "'а"),
            new KeyValuePair<string, string>("е", "'э"),
            new KeyValuePair<string, string>("ё", "'о")
        };
        private readonly KeyValuePair<string, string>[] CoupleSoftVowels = new KeyValuePair<string, string>[]
        {
            new KeyValuePair<string, string>("ю", "йу"),
            new KeyValuePair<string, string>("я", "йа"),
            new KeyValuePair<string, string>("е", "йэ"),
            new KeyValuePair<string, string>("ё", "йо")
        };
        private readonly KeyValuePair<string, string>[] RingingAndDeaf = new KeyValuePair<string, string>[]
        {
            new KeyValuePair<string, string>("б", "п"),
            new KeyValuePair<string, string>("в", "ф"),
            new KeyValuePair<string, string>("г", "к"),
            new KeyValuePair<string, string>("з", "с"),
            new KeyValuePair<string, string>("д", "т"),
            new KeyValuePair<string, string>("ж", "ш")
        };

        /// <summary>
        /// Initializing a word in this class.
        /// </summary>
        /// <param name="word">Entered point from EntryPoint</param>
        public PhoneticConverter(string word)
        {   
            this.word = word;
        }

        /// <summary>
        /// Word properties.
        /// </summary>
        private string Word
        {
            get
            {
                return word;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("No word was entered.");
                }
                if (value[0] == '+')
                {
                    throw new Exception("The stress cannot be the first character. ");
                }
                if (!value.Contains("+"))
                {
                    var temporaryListOfVowels = new List<string>();
                    foreach (var el in value)
                    {
                        if (ListOfVowels.Contains(el.ToString()))
                        {
                            temporaryListOfVowels.Add(el.ToString());
                        }
                    }
                    if (temporaryListOfVowels.Count > 1 && !temporaryListOfVowels.Contains("ё"))
                    {
                        throw new Exception("No stress in the word.");
                    }
                }
                for (int i = 1; i < value.Length - 1; i++)
                {
                    if (ListOfConsonants.Contains(value[i].ToString()) && value[i + 1] == '+')
                    {
                        throw new Exception("The stress after the consonant.");
                    }
                }

            }
        }
        /// <summary>
        ///This method realized all functions to convert a string. 
        /// </summary>
        public StringBuilder Converter()
        {   
            if(StressСheck() == true)
            {
                EnumArray();
                ConvertToA();
                DeletePlus();
                ConvertVowels();
                SoftVowelsConverter();
                RingingAndDeafConverter();
                NewStringMaker();
                return newString;
            }
            else
            {
                throw new Exception("Unexpected error");
            }  
        }

        /// <summary>
        /// This method checks if the word is stressed.
        /// </summary>
        /// <returns>True is stressed.Exception if not.</returns>
        private bool StressСheck()
        {
            int counterOfVowel = 0;
            if (!Word.Contains("+"))
            {
                if (!Word.Contains("ё"))
                {
                    foreach (var el in Word)
                    {
                        if (ListOfVowels.Contains(el.ToString()))
                        {
                            counterOfVowel++;
                        }
                    }
                }
            }
            if (counterOfVowel > 1)
            {
                throw new Exception("This word does not define a stressed vowel");
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This method fills listOfLetters which each object has prev,next,current letters.
        /// </summary>
        private void EnumArray()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                Letters obj = new Letters();
                if (i != 0)
                {
                    obj.Prev = Word[i - 1].ToString();
                }
                if (i != Word.Length - 1)
                {
                    obj.Next = Word[i + 1].ToString();
                }
                obj.Current = Word[i].ToString();
                ListOfLetters.Add(obj);
            }
        }

        /// <summary>
        /// This method checks unstressed 'о' and converts to 'a'.
        /// </summary>
        private void ConvertToA()
        {
            foreach (var obj in ListOfLetters)
            {
                if (obj.Current == "о" && obj.Next != "+")
                {
                    obj.Current = "a";
                }
            }
        }

        /// <summary>
        /// Delete object "+".
        /// </summary>
        private void DeletePlus()
        {
            for (int i = 0; i < ListOfLetters.Count; i++)
            {
                if (ListOfLetters[i].Current == "+" && i != ListOfLetters.Count - 1 && i != 0)
                {
                    ListOfLetters[i - 1].Next = ListOfLetters[i + 1].Current;
                    ListOfLetters[i + 1].Prev = ListOfLetters[i - 1].Current;
                    ListOfLetters.Remove(ListOfLetters[i]);
                }
                if (ListOfLetters[i].Current == "+" && i == ListOfLetters.Count - 1)
                {
                    ListOfLetters[i - 1].Next = null;
                    ListOfLetters.Remove(ListOfLetters[i]);
                }
            }
        }

        /// <summary>
        /// This method convert vowels sound before consonants.
        /// </summary>
        private void ConvertVowels()
        {
            foreach (var obj in ListOfLetters)
            {
                foreach (var elem in SoftVowels)
                {
                    if (ListOfConsonants.Contains(obj.Prev) && obj.Current == elem.Key)
                    {
                        obj.Current = elem.Value;
                    }
                }
            }
        }

        /// <summary>
        /// This method convert vowels to soft vowels if if they are at the beginning of the word,
        /// after vowels or after 'ъ' and 'ь'.
        /// </summary>
        private void SoftVowelsConverter()
        {
            for (int i = 0; i < ListOfLetters.Count; i++)
            {
                foreach (var elem in CoupleSoftVowels)
                {
                    if (ListOfLetters[0].Current == elem.Key)
                    {
                        ListOfLetters[i].Current = elem.Value;
                    }
                    if ((ListOfLetters[i].Prev == "ъ" || ListOfLetters[i].Prev == "ь")
                        && ListOfLetters[i].Current == elem.Key)
                    {
                        ListOfLetters[i - 1].Current = "'";
                        ListOfLetters[i].Current = elem.Value;
                    }
                    if (ListOfVowels.Contains(ListOfLetters[i].Prev) && ListOfLetters[i].Current == elem.Key)
                    {
                        ListOfLetters[i].Current = elem.Value;
                    }
                }
            }
        }

        /// <summary>
        /// this method translates the sounds of the rule vocalization/stunning consonants.
        /// </summary>
        private void RingingAndDeafConverter()
        {   
            for (int i = 0; i < ListOfLetters.Count; i++)
            {   
                foreach (var elem in RingingAndDeaf)
                {
                    if (ListOfLetters[ListOfLetters.Count - 1].Current == elem.Key 
                        && ListOfRinging.Contains(ListOfLetters[i].Current)) 
                    {
                        ListOfLetters[ListOfLetters.Count - 1].Current = elem.Value;
                    }
                    if (ListOfLetters[i].Current == elem.Key && ListOfDeaf.Contains(ListOfLetters[i].Next))
                    {
                        ListOfLetters[i].Current = elem.Value;
                    }
                    if (ListOfLetters[i].Current == elem.Value && ListOfRinging.Contains(ListOfLetters[i].Next))
                    {
                        ListOfLetters[i].Current = elem.Key;
                    }
                    if (ListOfLetters[ListOfLetters.Count - 2].Current == elem.Key 
                        && ListOfLetters[ListOfLetters.Count - 1].Current == "ь"
                        && ListOfRinging.Contains(ListOfLetters[i].Current))
                    {
                        ListOfLetters[ListOfLetters.Count - 2].Current = elem.Value;
                    }
                    if (ListOfLetters[i].Current == "ь" && ListOfRinging.Contains(ListOfLetters[i].Next)
                        && ListOfDeaf.Contains(ListOfLetters[i].Prev) && ListOfLetters[i - 1].Current == elem.Value)  
                    {
                        ListOfLetters[i - 1].Current = elem.Key; 
                    }
                }   
            }
        }

        /// <summary>
        /// This method connected all class objects Letters in one string.
        /// </summary>
        private StringBuilder NewStringMaker()
        {
            foreach (var elem in ListOfLetters)
            {
                newString.Append(elem.Current);
            }
            newString.Replace("ь", "'");
            return newString;
        }

        /// <summary>
        /// This method displays converted from letters to sounds string.
        /// </summary>
        public void Display()
        {
            Console.WriteLine(newString.ToString());
        }
    }
}
