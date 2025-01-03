using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OddOrEvenProgram
{
	public class OddOrEven
	{
		public static void Main(string[] args)
		{
		  
		  //Variable Declaration
		  int i;
		  
			Console.Write("Enter Your Input:");
			
	 	//Convert the string input into integer
			i=int.Parse(Console.ReadLine());
			
			//Checking
			if(i%2==0)
			{
			  Console.WriteLine("The given input is Even");
			  Console.Read();
			}
			else
			{
			  Console.WriteLine("The given input is ODD");
			  Console.Read();
			}
		}
	}
}