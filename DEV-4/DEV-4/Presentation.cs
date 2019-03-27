using System.Linq;

namespace DEV_4
{
    class Presentation : Materials
    {
        public string[] ArrOfFormat = new string[] { "PDF", "PPT" };
        public string URI { get; set; }
        public string FormatOfPresentation { get; set; }
        public Presentation(string discription, string format, string uri) : base(discription)
        {
            this.URI = uri;
            if (ArrOfFormat.Contains(format))
            {
                FormatOfPresentation = format;
            }
            else
            {
                FormatOfPresentation = "Unknown";
            }        
        }
        private Presentation(string discription, string uri, string format, string id) : this(discription, format, uri)
        {
            this.Data.id = id;
        }
        public override string GetID()
        {
            return this.Data.id;
        }
        public object Clone()
        {
            return new Presentation(Data.description, URI, FormatOfPresentation,Data.id);
        }
    }
}
