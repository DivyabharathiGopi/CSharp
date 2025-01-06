using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class PerfectNumber
	{
		public static void Main(string[] args)
		{
		  int sum=0,N;
			Console.WriteLine("Enter your input");
			N=int.Parse(Console.ReadLine());
			
			for(int i=1;i<N;i++)
			{
			  if(N%i==0)
			  {
			    sum=sum+i;
			  }
			}
			if(sum==N)
			{
			  Console.WriteLine("Perfect Number!");
			}
			else
			{
			  Console.WriteLine("Not a Perfect Number!");
			}
		}
	}
}