using System;

public class PatternsProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Rows:");
        int N=int.Parse(Console.ReadLine());
        for(int i=0;i<N;i++)
        {
            for(int j=0;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
