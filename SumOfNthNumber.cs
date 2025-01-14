using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfNthNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int N,sum=0;
			Console.WriteLine("Enter Nth number:");
			N=int.Parse(Console.ReadLine());
			for(int i=0;i<=N;i++)
			{
			  sum+=i;
			}
			Console.WriteLine("Sum of Entered Nth number "+N+" is : "+sum);
			Console.ReadKey();
		}
	}
}