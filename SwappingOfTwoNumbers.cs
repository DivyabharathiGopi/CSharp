using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SwappingOfTwoNumbers
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int num1,num2;
			Console.WriteLine("First number:");
			num1=int.Parse(Console.ReadLine());
			Console.WriteLine("Second number:");
			num2=int.Parse(Console.ReadLine());
      Console.WriteLine("Before Swapping Num1:"+num1);
      Console.WriteLine("Before Swapping Num2:"+num2);
			num1=num1+num2-(num2=num1);
			Console.WriteLine("After Swapping Num1:"+num1);
			Console.WriteLine("After Swapping Num2:"+num2);
		}
	}
}