using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUpdates
{
    internal class Final : Exam
    {
        public override void ShowExam()
        {
            int Mark = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine($"Question: {question.Header}");
                Console.WriteLine($"Option: {question.Body}");
                Console.WriteLine("Enter your answer (1, 2, 3, etc.):");
                int userAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine($"Correct Answer: {question.Answers[question.CorrectAnswer - 1].AnswerText}");

                if (userAnswer == question.CorrectAnswer)
                {
                    Mark += question.Mark;
                }
                Console.WriteLine($"the final score is {Mark} from {question.Mark}");
            }
        }

    }
}
