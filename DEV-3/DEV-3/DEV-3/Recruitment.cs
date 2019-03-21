using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// The main class of my criteria.
    /// </summary>
    abstract class Recruitment
    {
        public int Amount { get; protected set; }
        public int Efficiency { get; protected set; }
        protected List<int> ListOfEmployee = new List<int>() { 0, 0, 0, 0 };
        protected Junior objJunior = new Junior();
        protected Middle objMiddle = new Middle();
        protected Senior objSenior = new Senior();
        protected Lead objLead = new Lead();
        public virtual List<int> Choose()
        {
            return new List<int>();
        }
    }
}
