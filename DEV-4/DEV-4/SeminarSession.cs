using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class SeminarSession : Materials
    {
        private List<string> ListOfTasks = new List<string>();
        private List<KeyValuePair<string, string>> ListQuestionAndAnswer = new List<KeyValuePair<string, string>>();
        public SeminarSession(string discription) : base(discription)
        {

        }
        private List<string> TaskSetting()
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
        private List<KeyValuePair<string,string>> ListOfTaskWithAnswer()
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
        public override string GetID()
        {
            return this.Data.id;
        }
    }
}
