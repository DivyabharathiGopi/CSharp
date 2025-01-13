using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReverseNumber
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int num,rev=0;
			Console.Write("Number: ");
			num=int.Parse(Console.ReadLine());
			while(num!=0)
			{
			  rev=rev*10;
			  rev=rev+num%10;
			  num/=10;
			}
			Console.WriteLine("After reversing:"+rev);
		}
	}
}