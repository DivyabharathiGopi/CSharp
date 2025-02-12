using System;

public class TryCatch
{
    public static void Main(string[] args)
    {
        int result =0;
        try
        {
            Console.WriteLine("Enter the number");
            int num1=int.Parse(Console.ReadLine());
            int num2=0;
            result = num1/num2;
        }
        catch(Exception e)
        {
             Console.WriteLine ("Error: "+e.Message);
        }
        
        Console.WriteLine("Result:" +result);
        Console.ReadKey();       
    }
}
