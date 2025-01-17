using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrimeNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int N,M,flag=0;
			Console.WriteLine("Enter your number to check:");
			N=int.Parse(Console.ReadLine());
			M=N/2;
			for(int i=2;i<=M;i++)
			{
			  if(N%i==0)
			  {
			    Console.WriteLine("Not a prime number!");
			    flag=1;
			    break;
			  }
			}
			if(flag==0)
			{
			  Console.WriteLine("Prime number!");
			}
			Console.ReadKey();
		}
	}
}