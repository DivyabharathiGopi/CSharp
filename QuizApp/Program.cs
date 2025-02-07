using System;
namespace QuizApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        Question[] questions=new Question[]
        {
            new Question
            (
                "what is 1+1?",
                new string[] {"1","2","3","4"},
                1
            ) ,
            new Question
            (
                "what is 1+2?",
                new string[] {"1","2","3","4"},
                2
            ) ,
            new Question
            (
                "what is 1+3?",
                new string[] {"1","2","3","4"},
                3
            ) 
        };
        Quiz myQuiz=new Quiz(questions);
        myQuiz.StartQuiz();
        Console.ReadKey();
        }
    }
}
