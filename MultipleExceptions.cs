using System;

public class MultipleExceptions
{
    public static void Main(string[] args)
    {
       HandleMultipleExceptions("2", 1); //print the element in array index 1
        HandleMultipleExceptions("abc", 1); //print "Invalid format."
        HandleMultipleExceptions("2", 5); 
    }
 static void HandleMultipleExceptions(string str, int index)
        {
            // TODO
            int[] numbers = { 1, 2, 3 };
            
            try{
                int num=int.Parse(str);
                Console.WriteLine(numbers[index]);
            }catch(FormatException)
            {
                Console.WriteLine("Invalid format.");
            }catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
}
