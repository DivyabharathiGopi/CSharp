using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfMultiples
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int a,b,sum=0;
		  for(int i=1;i<100;i++)
		  {
		    a=i%3;
		    b=i%5;
		    if(a==0 || b==0)
		    {
		      Console.Write("{0}\t",i);
		      sum+=i;
		    }
		  }
		  Console.WriteLine();
			Console.WriteLine(" Sum of all 3 and 5 multiple below 100 is : "+sum);
			Console.ReadKey();
		}
	}
}