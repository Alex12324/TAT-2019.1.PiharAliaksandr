using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class DescriptionEntity
    {
        public string description;
        public string id;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length > 256)
                {
                    throw new Exception("The description is very long");
                }
                else
                {
                    this.description = value;
                }
            }
        }
        public DescriptionEntity()
        {
            id = StringExpansion.GetID(Description);
        }
        public DescriptionEntity(string Discription) : this()
        {
            this.Description = Discription;
        }
        public object Clone()
        {
            return new DescriptionEntity(this.description);
        }
    }
}
