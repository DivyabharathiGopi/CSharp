using System;
using System.Collections.Generic;
using System.Linq;

public class OddNums
{
    public static void Main(string[] args)
    {
        IEnumerable<int> nums = Enumerable.Range(20,30).Where(x=>x%2 !=0);
        foreach(int i in nums)
        {
            Console.WriteLine(i);
        }
    }
}