using System;
using System.Collections.Generic;

public class CharacterCount
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a string
        Console.WriteLine("Enter your string");
        
        // Read the input string from the user
        string str = Console.ReadLine();
        
        // Create a dictionary to store each character and its count
        // The key will be the character, and the value will be the count of occurrences
        Dictionary<char, int> characterAndCount = new Dictionary<char, int>();
        
        // Loop through each character in the input string
        foreach (var character in str)
        {
            // Skip spaces to only count non-space characters
            if (character != ' ')
            {
                // If the character is not already in the dictionary
                if (!characterAndCount.ContainsKey(character))
                {
                    // Add the character to the dictionary with a count of 1
                    characterAndCount.Add(character, 1);
                }
                else
                {
                    // If the character is already in the dictionary, increment its count
                    characterAndCount[character]++;
                }
            }
        }
        
        // After processing all characters, print the count for each character
        foreach (var character in characterAndCount)
        {
            // Output each character and its count in the format: character - count
            Console.WriteLine("{0} - {1}", character.Key, character.Value);
        }
    }
}
