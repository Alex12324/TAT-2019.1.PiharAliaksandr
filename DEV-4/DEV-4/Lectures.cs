using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class Lectures : Materials
    {
        List<Presentation> ListOfPresentations = new List<Presentation>();
        List<SeminarSession> ListOfSeminars = new List<SeminarSession>();
        List<LaboratoryResearchcs> ListOfLabworks = new List<LaboratoryResearchcs>();
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
            this.Data.Discription = discription;
            this.Data.id = Data.id;
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
    }
}
