using System;

public class ReverseOrderWords
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a string
        Console.WriteLine("Enter your string");
        
        // Read the input string from the user
        string str = Console.ReadLine();
        
        // Split the input string into words (by spaces) and store them in an array
        string[] splitStr = str.Split(" ");
        
        // Initialize two pointers: start at the beginning and end at the last word
        int start = 0;
        int end = splitStr.Length - 1;
        
        // Use a while loop to swap words until the pointers meet in the middle
        while (start < end)
        {
            // Temporarily store the word at the start index
            string temp = splitStr[start];
            
            // Swap the word at the start index with the word at the end index
            splitStr[start] = splitStr[end];
            splitStr[end] = temp;
            
            // Move the start pointer towards the center
            start++;
            
            // Move the end pointer towards the center
            end--;
        }
        
        // Loop through the array and print each word with a space
        foreach (string s in splitStr)
        {
            Console.Write(s + " ");
        }
    }
}
