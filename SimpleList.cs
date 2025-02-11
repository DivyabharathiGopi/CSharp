using System;
using System.Collections.Generic;

public class SimpleList
{
    public static void Main(string[] args)
    {
        //List declaration and intialization
        List<int> items = new List<int>{1,2,3};
         
         //Itereation over the list
        foreach(int item in items)
        {
            Console.Write(item+" ");
        }
    }
}
