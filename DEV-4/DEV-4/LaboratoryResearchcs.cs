
namespace DEV_4
{
    /// <summary>
    /// Laboratory class.
    /// </summary>
    class LaboratoryResearchcs : Materials
    {
        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="description"></param>
        public LaboratoryResearchcs(string description = null) : base(description)
        {
       
        }

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="id"></param>
        private LaboratoryResearchcs(string description, string id) : this(description)
        {
            this.Data.id = id;
        }

        /// <summary>
        /// This method returns copy of LaboratoryResearchcs object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new LaboratoryResearchcs(Data.Description,Data.id);
        }
    }
}
