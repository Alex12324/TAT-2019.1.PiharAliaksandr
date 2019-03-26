using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                FormatOfPresentation = "Unknown";
        }
        public override string GetID()
        {
            return this.Data.id;
        }
    }
}
