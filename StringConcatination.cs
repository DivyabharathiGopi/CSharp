using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringConcatination
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string s1,s2,s3;
			Console.WriteLine("First String:");
			s1=Console.ReadLine();
			Console.WriteLine("Second String:");
			s2=Console.ReadLine();
			s3=string.Concat(s1,s2);
			Console.WriteLine("Final String : "+s3);
			Console.ReadKey();
		}
	}
}