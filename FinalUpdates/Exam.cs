using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUpdates
{
    internal class Exam
    {
        public int Time { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public virtual void ShowExam()
        {

        }

    }
}
