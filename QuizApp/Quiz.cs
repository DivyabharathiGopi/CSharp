using System;
namespace QuizApp
{
    internal class Quiz
    {
        //creating Collection of question objects arrays
        private Question[] _questions;
        private int _score;

        //Constructor
        public Quiz(Question[] question)
        {
            _questions=question;
            _score=0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber=1;
            foreach(Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userchoice=GetUserInput();
                if(question.IsCorrectAnswer(userchoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else{
                    Console.WriteLine($"Wrong Answer! The correct answer was {question.Choices[question.CorrectAnswerIndex]}");
                }
            }
            DisplyResults();
        }

        //Display Question with choices
        private void DisplayQuestion(Question question)
        {
            //Display question
            Console.WriteLine($"{question.QuestionText}");

            //Display choices
            for(int i=0;i<question.Choices.Length;i++)
            {
                Console.Write(i+1);
                Console.WriteLine($".{question.Choices[i]}");
            }
        }

        //Getting user input and checking
        private int  GetUserInput()
        {
            Console.WriteLine("Enter your ansswer (1-4): ");
            string input=Console.ReadLine();
            int choice=0;
            while(!int.TryParse(input,out choice)|| choice<1 || choice>4)
            {
                Console.WriteLine($"Invalid option. Enter your choice again (1-4)");
                input=Console.ReadLine();
            }
            return choice;
        }

        private void DisplyResults()
        {
            double percentage=_score/_questions.Length;
            Console.WriteLine($"Quiz finished! your score {_score} out of {_questions.Length}.");
            if(percentage>=0.8)
            {
                Console.WriteLine("Excellent!");
            }
            else if(percentage>=0.5)
            {
                Console.WriteLine("Good Work!");
            }
            else{
                Console.WriteLine("Keep practicing");
            }
        }
    }
}
 