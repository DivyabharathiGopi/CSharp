using System;

namespace QuestApp
{
    internal class Quiz
    {
        private Question[] questions;
        private int score;

        public Quiz(Question[] questions)
        {
            this.questions=questions;
            score=0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Wlcome to the quiz");
            int questionNumber=1;
            foreach(Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice=GetUserInput();
                if(question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    score++;

                }
                else{
                    //Console.WriteLine($"Wrong Answer. The correct answer is {question.Choices[question.CorrectAnswerIndex]}");
                    Console.WriteLine($"Wrong Answer. The correct answer is {question.Choices[question.CorrectAnswerIndex]}");
                }
            }
            DisplyResults();
        }

        private void DisplyResults()
        {
             Console.WriteLine($"Finished! Your score is {score} out of {questions.Length}");
             
             double percentage = (double)score / questions.Length;

             if(percentage>=0.8)
             {
                Console.WriteLine("Excellent!");
             }
             else if(percentage>=0.5)
             {
                Console.WriteLine("GoodWork!");
             }
             else 
             {
                Console.WriteLine("Keep practicing!");
             }
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
            for(int i=0;i<question.Choices.Length;i++)
            {
                Console.ForegroundColor =ConsoleColor.Cyan;
                Console.Write(" ");
                Console.Write(i+1);
                Console.ResetColor();
                Console.WriteLine($". {question.Choices[i]}");
            }
            // if(GetUserInput() == question.CorrectAnswerIndex)
            // {
            //     Console.WriteLine("Correct!");
            // }
            // else{
            //     Console.WriteLine("Incorrect!");
            // }
        }

        public int GetUserInput()
        {
            Console.WriteLine("Enter your answer(1-4) : ");
            string input = Console.ReadLine();
            int choice=0;
            while(!int.TryParse(input, out choice)|| choice<1 || choice>4)
            {
                Console.WriteLine("Invalid choice. Please enter valid input(1-4)!");
                input=Console.ReadLine();
            }
            return choice;
        } 
    } 
}
