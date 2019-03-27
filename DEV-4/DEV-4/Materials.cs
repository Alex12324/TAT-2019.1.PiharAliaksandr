
namespace DEV_4
{   
    /// <summary>
    /// 
    /// </summary>
    abstract class Materials 
    {
        public DescriptionEntity Data { get; set; }

        /// <summary>
        /// Сlass constructor.
        /// </summary>
        /// <param name="Description"></param>
        public Materials(string Description = null)
        {
            Data = new DescriptionEntity(Description);
        }

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <param name="data"></param>
        private Materials(DescriptionEntity data)
        {
            this.Data = (DescriptionEntity)data.Clone();
        }

        /// <summary>
        /// Overridden method ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Discription : {Data.Description}";
        }

        /// <summary>
        /// Override the Equals() method of entity comparison.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method returns copy of Clone object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new DescriptionEntity();
        }

        /// <summary>
        /// Method which returns id.
        /// </summary>
        /// <returns></returns>
        public virtual string GetID()
        {
            return Data.id;
        }
    }
}
