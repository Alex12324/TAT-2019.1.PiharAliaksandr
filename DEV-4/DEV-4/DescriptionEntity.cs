using System;

namespace DEV_4
{
    /// <summary>
    /// Class for containing general information of entities (GUID and Description).
    /// </summary>
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

        /// <summary>
        /// The class constructor.
        /// </summary>
        public DescriptionEntity()
        {
            id = StringExpansion.GetID(Description);
        }

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="Description"></param>
        public DescriptionEntity(string Description) : this()
        {
            this.Description = Description;
        }

        /// <summary>
        /// This method returns copy of DescriptionEntity object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new DescriptionEntity(this.description);
        }
    }
}
