using System;

namespace QuestApp
{
    internal class Question
    {
       public string QuestionText {get;set;}
       public string[] Choices {get;set;}
       public int CorrectAnswerIndex {get;set;}

       public Question(string questionText,string[] choices,int correctAnswerIndex)
       {
        QuestionText=questionText;
        Choices=choices;
        CorrectAnswerIndex=correctAnswerIndex;
       }

       public bool IsCorrectAnswer(int userChoice)
       {
        return CorrectAnswerIndex==(userChoice-1);
       }
    }
}
