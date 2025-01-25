namespace FinalUpdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets start  the exam ");
            Console.WriteLine("Enter The Type Of Exam 1 is Partical 2 is Final");
            int examTypeChoice = int.Parse(Console.ReadLine());
            Exam exam;
            if (examTypeChoice == 1)
            {
                exam = new ParticalExam();
            }
            else
            {
                exam = new Final();
            }

            Console.WriteLine("enter the time of exam ");
            exam.Time = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number of question");
            int numberOfQuestion = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfQuestion; i++)
            {
                Console.WriteLine("Enter type of question");
                Console.WriteLine("1 is MCQ 2 is True/False");
                int questionType = int.Parse(Console.ReadLine());
                Question question;
                if (questionType == 1)
                {
                    question = new Mcq();
                }
                else
                {
                    question = new TrueOrFalse();
                }


                #region DataOfQustions
                Console.WriteLine("Enter The Question Header");
                question.Header = Console.ReadLine();
                Console.WriteLine("Enter The Question Body");
                question.Body = Console.ReadLine();
                Console.WriteLine("Enter The Mark Of The Question");
                question.Mark = int.Parse(Console.ReadLine());
                #endregion

                Console.WriteLine("Enter The Number Of The Answer");
                int numberOfAnswer = int.Parse(Console.ReadLine());


                question.Answers = new Answer[numberOfAnswer];

                for (int j = 0; j < numberOfAnswer; j++)
                {
                    Console.WriteLine($"Enter the answer text for option {j + 1}:");
                    question.Answers[j] = new Answer { AnswerID = j + 1, AnswerText = Console.ReadLine() };
                }

                Console.WriteLine("Enter the correct answer number:");
                question.CorrectAnswer = int.Parse(Console.ReadLine());

                exam.AddQuestion(question);
                Console.WriteLine("\nExam created successfully!");
                Console.WriteLine($"Time: {exam.Time} minutes");
                Console.WriteLine($"Number of Questions: {exam.Questions.Count}\n");
                exam.ShowExam();

            }
        }
    }
}
