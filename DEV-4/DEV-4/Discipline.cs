using System;
using System.Collections.Generic;

namespace DEV_4
{
    class Discipline : DescriptionEntity,ICloneable
    {
        public List<Lectures> lectures;
        public List<SeminarSession> seminars;
        public List<LaboratoryResearchcs> labs;
        DescriptionEntity data;

        public Discipline(string description)
            : base(description)
        {
            lectures = new List<Lectures>();
            seminars = new List<SeminarSession>();
            labs = new List<LaboratoryResearchcs>();
        }

        private Discipline(string description, List<Lectures> lectures, List<SeminarSession> seminars, 
            List<LaboratoryResearchcs> labs, string id) : this(description)
        {
            data.id = id;
            foreach (var lecture in lectures)
            {
                this.lectures.Add((Lectures)lecture.Clone());
            }

            foreach (var seminar in seminars)
            {
                this.seminars.Add((SeminarSession)seminar.Clone());
            }

            foreach (var lab in labs)
            {
                this.labs.Add((LaboratoryResearchcs)lab.Clone());
            }
        }
        public List<Materials> this[string description]
        {
            get
            {
                var materials = new List<Materials>();
                foreach (var el in lectures) 
                {
                    if (el.Data.Description == description)
                    {
                        materials.Add(el);
                    }
                }
                foreach (var el in seminars)
                {
                    if (el.Data.Description == description)
                    {
                        materials.Add(el);
                    }
                }
                foreach (var el in labs)
                {
                    if (el.Data.Description == description)
                    {
                        materials.Add(el);
                    }
                }
                return materials;
            }    
        }
        public object Clone()
        {
            var disciplineCopy = new Discipline(this.data.description, this.lectures, this.seminars, this.labs, this.data.id);
            return disciplineCopy;
        }
    }
}
