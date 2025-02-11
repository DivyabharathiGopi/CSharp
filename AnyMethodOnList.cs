using System;
using System.Collections.Generic;
using System.Linq;

public class AnyMethodOnList
{
    public static void Main(string[] args)
    {
       //List declaration and intialization
       List<int> myNumbers = new List<int> { 1, 6, 3 };

       //TODO: Check if any number is greater than 5 using the Any method
       bool isGreaterThanFive = myNumbers.Any(x=>x>5);
            
       //and print the result ("True" or "False") to the console.
       if(isGreaterThanFive)
       {
           Console.WriteLine("True");
       }
       else
       {
           Console.WriteLine("False");
        }
    }
}
