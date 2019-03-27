using System;
using System.Collections.Generic;

namespace DEV_4
{
    /// <summary>
    ///  Class for seminars session.
    /// </summary>
    class SeminarSession : Materials
    {
        private List<string> ListOfTasks = new List<string>();
        private List<KeyValuePair<string, string>> ListQuestionAndAnswer = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="description"></param>
        public SeminarSession(string description) : base(description)
        {

        }

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="ListOfTasks"></param>
        /// <param name="ListQuestionAndAnswer"></param>
        /// <param name="id"></param>
        private SeminarSession(string description,List<string> ListOfTasks,
            List<KeyValuePair<string,string>> ListQuestionAndAnswer,string id): this(description)
        {
            this.Data.id = id;
            foreach (var task in ListOfTasks)
            {
                this.ListOfTasks.Add(task);
            }

            foreach (var key in ListQuestionAndAnswer)
            {
                this.ListQuestionAndAnswer.Add(key);
            }
        }

        /// <summary>
        /// The private class constructor for making deep copy of this object.
        /// </summary>
        /// <returns></returns>
        public List<string> TaskSetting()
        {
            Console.WriteLine("How many tasks do you want to add?Enter please :");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                Console.WriteLine("Enter the task : ");
                for (int i = 0; i < count; i++)
                {
                    ListOfTasks.Add(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("The number of tanks is zero. ");
            }
            return ListOfTasks;
        }

        /// <summary>
        /// The method adds questions and answers.
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string,string>> ListOfTaskWithAnswer()
        {
            Console.WriteLine("How many tasks do you want to add? Enter please: ");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 0)
            {
                Console.WriteLine("Enter the tasks and answer: ");
                for (int i = 0; i < count; i++) 
                {
                    ListQuestionAndAnswer.Add(new KeyValuePair<string, string>(Console.ReadLine(),Console.ReadLine()));
                } 
            }
            else
            {
                Console.WriteLine("The number of tanks is zero. ");
            }
            return ListQuestionAndAnswer;
        }

        /// <summary>
        /// Method which returns id.
        /// </summary>
        /// <returns></returns>
        public override string GetID()
        {
            return this.Data.id;
        }

        /// <summary>
        /// This method returns copy of SeminarSession object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new SeminarSession(this.Data.Description, this.ListOfTasks, this.ListQuestionAndAnswer, this.Data.id);
        }
    }
}
