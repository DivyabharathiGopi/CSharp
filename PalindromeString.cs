using System;

public class PalindromeString
{
    // Main method where the execution of the program starts
    public static void Main(string[] args)
    {
        // Ask the user to enter a string
        Console.WriteLine("Enter your string:");

        // Read the string input from the user
        string str = Console.ReadLine();

        // Initialize an empty string to hold the reversed version of the input string
        string reversedStr = "";

        // Loop through the string starting from the last character to the first
        for (int i = str.Length - 1; i >= 0; i--)
        {
            // Append each character of the string in reverse order to 'reversedStr'
            reversedStr += str[i];
        }

        // Compare the original string with the reversed string
        if (str == reversedStr)
        {
            // If the string is the same forwards and backwards, it's a palindrome
            Console.WriteLine("Yes, the given string is a palindrome!");
        }
        else
        {
            // If the string is not the same forwards and backwards, it's not a palindrome
            Console.WriteLine("No, the given string is not a palindrome!");
        }

        // Wait for the user to press a key before closing the program
        Console.ReadKey();
    }
}
