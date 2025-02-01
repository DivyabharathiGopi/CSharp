using System;

public class QuizApp
{
    public static void Main(string[] args)
    {
        //storing question in 1D array 
        string[] questions = {
           "What is the capital of France?",
            "Which planet is known as the Red Planet?",
            "Who wrote 'Romeo and Juliet'?",
            "What is the largest mammal in the world?"  
        };
        
        // storing choices in 2D array
        string[,] choices = {
            { "1. Paris", "2. London", "3. Berlin", "4. Madrid" },
            { "1. Earth", "2. Mars", "3. Venus", "4. Jupiter" },
            { "1. Shakespeare", "2. Dickens", "3. Tolkien", "4. Austen" },
            { "1. Elephant", "2. Blue Whale", "3. Giraffe", "4. Rhinoceros" }
        };
        
        //storing correctAnswers in 1D array
        int[] correctAnswers = {1, 2, 1, 2};
        
        //initializing score
        int score=0;
        
        //print each question along with its choices
        for(int i=0;i<questions.Length;i++)
        {
            //question
            Console.WriteLine(questions[i]);
            for(int j=0;j<4;j++)
            {
                //choices
                Console.WriteLine(choices[i,j]);
            }
            
            //Getting answer from user
            Console.WriteLine("your answer(1-4):");
            int userAnswer;
            while(!int.TryParse(Console.ReadLine(), out userAnswer)|| userAnswer<1 || userAnswer>4)
            {
                Console.WriteLine("Enter valid input between[1-4]");
            }
            
            if(userAnswer==correctAnswers[i])
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            
            else
            {
                Console.WriteLine("Wrong Answer!, Correct answer is : "+correctAnswers[i]);
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Final score is: {score} out of {questions.Length} ");
        Console.ReadKey();
    }
}
