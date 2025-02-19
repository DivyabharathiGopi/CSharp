using System;

public class ReversingString
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter your string:");

        // Read the string input from the user
        string str = Console.ReadLine();

        // Initialize an empty string to store the reversed result
        string reversedStr = "";

        // Loop through the original string from the last character to the first
        for (int i = str.Length - 1; i >= 0; i--)
        {
            // Append the current character (from the end) to the reversed string
            reversedStr += str[i];
        }

        // Print the reversed string to the console
        Console.WriteLine(reversedStr);
    }
}
