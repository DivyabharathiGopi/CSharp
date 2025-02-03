
using System;

public class PrintRowSums
{
    public static void Main(string[] args)
    {
        // 2D Initialization
            int[,] arr = new int[3,3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int sum=0;
            for(int i=0;i<arr.GetLength(0);i++) // GetLenth(0) - will retun number of rows
            {
                for(int j=0;j<arr.GetLength(1);j++) // GetLength(1) - will return number of columns
                {
                    sum+=arr[i,j];
                }
                Console.WriteLine(sum);
                sum=0;
            }
            Console.ReadLine();
    }
}