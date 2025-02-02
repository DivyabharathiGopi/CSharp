using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            // Request input for the first number
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            // Request input for the second number
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Ask the user to choose an operation, ensuring there's a space after the colon
            Console.WriteLine("Choose an operation: +, -, *, /");
            string op = Console.ReadLine();

            // Perform the selected operation
            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }

            // End with a Console.ReadLine() to handle non-console environments
            Console.ReadLine();
        }
    }
}
