using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		    int num1,num2,sum1=0,sum2=0;
			Console.WriteLine("Enter your first number:");
			num1=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter your second number:");
			num2=int.Parse(Console.ReadLine());
			for(int i=1;i<num1;i++)
			{
			  if(num1%i==0)
			  {
			    sum1+=i;
			  }
			}
			for(int j=1;j<num2;j++)
			{
			  if(num2%j==0)
			  {
			    sum2+=j;
			  }
			}
			if((sum1==num2)&&(sum2==num1))
			{
			  Console.WriteLine("Amicable Number!");
			}
			else
			{
			  Console.WriteLine("Not a Amicable Number!");
			}
		}
	}
} 
