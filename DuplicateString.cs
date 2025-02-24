using System;

public class DuplicateString
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter your string");

        // Read the input string from the user
        string str = Console.ReadLine();

        // Initialize an empty string to store the result without duplicates
        string result = string.Empty;

        // Loop through each character in the input string
        for (int i = 0; i < str.Length - 1; i++)
        {
            // Check if the result string already contains the current character
            if (!result.Contains(str[i]))
            {
                // If not, add it to the result string
                result += str[i];
            }
        }

        // Output the string without duplicates
        Console.WriteLine(result);
    }
}
