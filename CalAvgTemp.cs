using System;

public class CalAvgTemp
{
    public static void Main(string[] args)
    {
        double[] temperatures = { 20.0, 25.0, 22.0, 22.5, 23.0 };
        PrintAverage(temperatures);
    }
    public static void PrintAverage(double[] temperatures)
    {
        Console.WriteLine($"The average temperature is: {CalculateAverage(temperatures)}");
    }
    public static double CalculateAverage(double[] temperatures)
    {
        double sum=0;
        foreach(double i in temperatures)
        {
            sum+=i;
        }
        return sum/temperatures.Length;
    }
}