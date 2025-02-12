using System;

public class TryCatchFinally
{
    public static void Main(string[] args)
    {
        int result =0;
        try
        {
            Console.WriteLine("Enter the first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2=int.Parse(Console.ReadLine());
            result = num1/num2;
        }
        catch(Exception e)
        {
             Console.WriteLine ("Error: "+e.Message);
        }
        finally
        {
            Console.WriteLine("This finally keyword will always excutes!");
        }
        
        Console.WriteLine("Result:" +result);
        Console.ReadKey();       
    }
}
