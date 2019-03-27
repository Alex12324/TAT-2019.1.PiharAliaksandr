using System.Linq;

namespace DEV_4
{
    class Presentation : Materials
    {
        public string[] ArrOfFormat = new string[] { "PDF", "PPT" };
        public string URI { get; set; }
        public string FormatOfPresentation { get; set; }

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="discription"></param>
        /// <param name="format"></param>
        /// <param name="uri"></param>
        public Presentation(string description, string format, string uri) : base(description)
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

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="uri"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        private Presentation(string description, string uri, string format, string id) : this(description, format, uri)
        {
            this.Data.id = id;
        }

        /// <summary>
        /// Method which returns id.
        /// </summary>
        /// <returns></returns>
        public override string GetID()
        {
            return this.Data.id;
        }

        /// <summary>
        /// This method returns copy of Presentation object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Presentation(Data.Description, URI, FormatOfPresentation,Data.id);
        }
    }
}
