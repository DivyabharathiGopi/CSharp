using System;
using System.Collections.Generic;

public class Product
{
    //properties
    public string Name {get;set;}
    public double Price {get;set;}
}

public class PropertyListProgram
{
    public static void Main(string[] args)
    {
        //List Declaration and intialization - 'products' list with Product objects
        List<Product> products = new List<Product>
        {
            new Product {Name="Apple", Price = 0.80},
            new Product {Name="Banana", Price = 0.50},
        };

        //iteration
        foreach(Product product in products)
        {
            Console.WriteLine($"{product.Name} for {product.Price}");
        }
        
    }
}
