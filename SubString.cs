using System;

public class SubString
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a string
        Console.Write("Enter your string: ");
        string str = Console.ReadLine();  // Store the user input string
        
        // Outer loop: Iterates over each starting index of the substring
        // We need to go through all indices from 0 to str.Length
        for (int i = 0; i < str.Length; i++)  // Use i < str.Length to avoid out of bounds error
        {
            // Inner loop: Iterates over each ending index of the substring
            // Starts from i+1 to ensure substrings of length >= 1
            for (int j = i + 1; j <= str.Length; j++)  
            {
                // Extracts the substring from index i to j-1
                string subStr = str.Substring(i, j - i);  // j - i gives the length of the substring
                
                // Print the substring
                Console.WriteLine(subStr);
            }
        }
    }
}
