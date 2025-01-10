using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfDigits
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int num,sum=0,rem;
			Console.WriteLine("Enter your number:");
			num=int.Parse(Console.ReadLine());
			while(num!=0)
			{
			  rem=num%10;
			  sum+=rem;
			  num/=10;
			}
			Console.WriteLine("Sum of Digits of your number is "+sum);
		}
	}
}