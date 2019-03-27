using System;
using System.Collections.Generic;

namespace DEV_4
{
    /// <summary>
    /// Lecture class.
    /// </summary>
    class Lectures : Materials
    {
        public List<Presentation> ListOfPresentations = new List<Presentation>();
        public List<SeminarSession> ListOfSeminars = new List<SeminarSession>();
        public List<LaboratoryResearchcs> ListOfLabworks = new List<LaboratoryResearchcs>();
        public string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value != null && value.Length < 100000)
                {
                    text = value;
                }
                else
                {
                    throw new Exception("Text cannot be longer than 100,000 characters or cannot be null");
                }
            }
        }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="text"></param>
        public Lectures(string description, string text) : base(description)
        {
            this.Text = text;
        }

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="text"></param>
        /// <param name="ListOfPresentations"></param>
        /// <param name="ListOfSeminars"></param>
        /// <param name="ListOfLabworks"></param>
        /// <param name="id"></param>
        private Lectures(string description, string text, List<Presentation> ListOfPresentations,
            List<SeminarSession> ListOfSeminars, List<LaboratoryResearchcs> ListOfLabworks,string id) : this(description, text)
        {
            this.ListOfPresentations = new List<Presentation>();
            this.ListOfSeminars = new List<SeminarSession>();
            this.ListOfLabworks = new List<LaboratoryResearchcs>();
            foreach (var el in ListOfPresentations)
            {
                this.ListOfPresentations.Add((Presentation)el.Clone());
            }
            foreach (var el in ListOfSeminars)
            {
                this.ListOfSeminars.Add((SeminarSession)el.Clone());
            }
            foreach (var el in ListOfLabworks)
            {
                this.ListOfLabworks.Add((LaboratoryResearchcs)el.Clone());
            }
            this.Data.id = id;
        }

        /// <summary>
        /// The method that adds the presentation.
        /// </summary>
        /// <returns></returns>
        public List<Presentation> AddingPresentation()
        {
            Console.WriteLine("Enter how many presentations you want to add :");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter description,format and uri in that order ");
                    string desc = Console.ReadLine();
                    string form = Console.ReadLine();
                    string uri = Console.ReadLine();
                    ListOfPresentations.Add(new Presentation(desc,form,uri));
                }
            }
            else
            {
                Console.WriteLine("In this lecture you have no presentations. ");
            }
            return ListOfPresentations;
        }

        /// <summary>
        /// The method that adds the SeminarSession.
        /// </summary>
        /// <returns></returns>
        public List<SeminarSession> AddingSeminarSession()
        {
            Console.WriteLine("Enter how many seminars you want to add :");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter description,format and uri in that order ");
                    ListOfSeminars.Add(new SeminarSession(this.Data.Description));
                }
            }
            else
            {
                Console.WriteLine("In this lecture you have no seminars. ");
            }
            return ListOfSeminars;
        }

        /// <summary>
        /// The method adds count number of presentations.
        /// </summary>
        /// <returns></returns>
        public List<LaboratoryResearchcs> ListOfLabs()
        {
            Console.WriteLine("Enter how many labs you want to add :");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter description,format and uri in that order ");
                    ListOfLabworks.Add(new LaboratoryResearchcs());
                }
            }
            else
            {
                Console.WriteLine("In this lecture you have no seminars. ");
            }
            return ListOfLabworks;
        }

        /// <summary>
        /// Methid which returns id.
        /// </summary>
        /// <returns></returns>
        public override string GetID()
        {
            return this.Data.id;
        }

        /// <summary>
        /// This method returns copy of Lectures object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Lectures(this.Data.Description,this.text,this.ListOfPresentations,this.ListOfSeminars,this.ListOfLabworks,this.Data.id);
        }
    }
}
