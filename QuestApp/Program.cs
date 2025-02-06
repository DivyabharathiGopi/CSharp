using System;

namespace QuestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions=new Question[]
            {
                new Question(
                    "what is 2+2?",
                    new string[] {"4","2","8","6"},
                    0
                ),
                new Question(
                    "what is 2+3?",
                    new string[] {"5","2","8","6"},
                    0
                ),
                new Question(
                    "what is 2+4?",
                    new string[] {"5","2","8","6"},
                    3
                )
            };

            Quiz myQuiz = new Quiz(questions);
            //myQuiz.DisplayQuestion(questions[0]);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
