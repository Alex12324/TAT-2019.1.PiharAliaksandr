
namespace DEV_4
{
    abstract class Materials 
    {
        public DescriptionEntity Data { get; set; }
        
        public Materials(string Discription = null)
        {
            Data = new DescriptionEntity(Discription);
        }
        private Materials(DescriptionEntity data)
        {
            this.Data = (DescriptionEntity)data.Clone();
        }
        public override string ToString()
        {
            return $"Discription : {Data.Description}";
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
        public object Clone()
        {
            return new DescriptionEntity();
        }
        public virtual string GetID()
        {
            return Data.id;
        }
    }
}
