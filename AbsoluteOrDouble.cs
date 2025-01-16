using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AbsoluteOrDouble
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int a,b, result;
			Console.WriteLine("First number: ");
			a=int.Parse(Console.ReadLine());
			Console.WriteLine("Second number: ");
			b=int.Parse(Console.ReadLine());
			if(a>b)
			{
			  result=(a-b)*2;
			  Console.WriteLine("Double value is: "+result);
			}
			if(b>a)
			{
			  result= (b-a);
			  Console.WriteLine("Absolute value is: "+result);
			}
			Console.ReadKey();
		}
	}
}