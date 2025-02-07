using System;
namespace QuizApp
{
    internal class Question
    {
        //Properties
        public string QuestionText {get;set;}
        public string[] Choices {get;set;}
        public int CorrectAnswerIndex {get;set;}

        //Constructor
        public Question(string questionText, string[] choices,int correctAnswerIndex)
        {
            QuestionText=questionText;
            Choices=choices;
            CorrectAnswerIndex=correctAnswerIndex;
        }

        // check answer
        public bool IsCorrectAnswer(int input)
        {
            return CorrectAnswerIndex==(input-1);
        }
    }
}
