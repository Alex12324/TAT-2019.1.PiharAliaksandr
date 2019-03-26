using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class DescriptionEntity
    {
        public string discription;
        public string id;
        public string Discription
        {
            get
            {
                return discription;
            }
            set
            {
                if (value.Length > 256)
                {
                    throw new Exception("The description is very long");
                }
                else
                {
                    this.discription = value;
                }
            }
        }
        public DescriptionEntity(string Discription)
        {
            id = StringExpansion.GetID(Discription);
            this.Discription = Discription;
        }
    }
}
