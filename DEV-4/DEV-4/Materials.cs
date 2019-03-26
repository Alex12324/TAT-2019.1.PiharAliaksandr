using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    abstract class Materials 
    {
        protected DescriptionEntity Data { get; set; }
        
        public Materials(string Discription = null)
        {
            Data = new DescriptionEntity(Discription);
        }
        public override string ToString()
        {
            return $"Discription : {Data.Discription}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Materials MatObj)
            {
                return (Data.id == MatObj.Data.id);
            }
            else
            {
                return false;
            }
        }
        public virtual string GetID()
        {
            return Data.id;
        }
    }
}
