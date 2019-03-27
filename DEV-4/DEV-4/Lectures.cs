using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
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
        public Lectures(string discription, string text) : base(discription)
        {
            this.Text = text;
        }
        private Lectures(string discription, string text, List<Presentation> ListOfPresentations,
            List<SeminarSession> ListOfSeminars, List<LaboratoryResearchcs> ListOfLabworks,string id) : this(discription, text)
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
        public List<SeminarSession> AddingSeminarSession()
        {
            Console.WriteLine("Enter how many seminars you want to add :");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter description,format and uri in that order ");
                    ListOfSeminars.Add(new SeminarSession(this.Data.Discription));
                }
            }
            else
            {
                Console.WriteLine("In this lecture you have no seminars. ");
            }
            return ListOfSeminars;
        }
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
        public override string GetID()
        {
            return this.Data.id;
        }
        public object Clone()
        {
            return new Lectures(this.Data.discription,this.text,this.ListOfPresentations,this.ListOfSeminars,this.ListOfLabworks,this.Data.id);
        }
    }
}
