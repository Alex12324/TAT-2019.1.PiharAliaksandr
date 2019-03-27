using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class LaboratoryResearchcs : Materials
    {
        public LaboratoryResearchcs(string discription = null) : base(discription)
        {

        }
        private LaboratoryResearchcs(string discription, string id) : this(discription)
        {
            this.Data.id = id;
        }
        public object Clone()
        {
            return new LaboratoryResearchcs(Data.Discription,Data.id);
        }
    }
}
