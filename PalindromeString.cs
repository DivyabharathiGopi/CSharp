using System;

public class PalindromeString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your string:");
       string str =Console.ReadLine();
       string reversedStr = "";
       for (int i=str.Length-1;i>=0;i--)
       {
          
           reversedStr+=str[i];
       }
       if(str == reversedStr)
       {
           Console.WriteLine("Yes, the given string is an palindrome!");
       }
       else
       {
           Console.WriteLine("No, the given string is not an palindrome!");
       }
       Console.ReadKey();
    }
}
