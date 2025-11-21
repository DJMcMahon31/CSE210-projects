using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address a1 = new("123 Main St", "Provo", "Utah", "USA");
        Customer c1 = new("Albert Albert", a1);
        Order o1 = new(c1, new List<Product>());   

        Address a2 = new("345 Baseline Rd", "Salt Lake City", "Utah", "USA");
        Customer c2 = new("Bob Bob", a2);
        Order o2 = new(c2, new List<Product>());

        Address a3 = new("789 Commercial Dr", "Ottawa", "Ontario", "Canada");
        Customer c3 = new("Charlie Charlie", a3);
        Order o3 = new(c3, new List<Product>());


        o1.AddProduct(new Product("common nails ", 10010, 2.99, 3, "Nails - Common"));    
        o1.AddProduct(new Product("finishing nails ", 10011, 4.99, 2, "Nails - Finishing"));
        o1.AddProduct(new Product("Robertson screws ", 11110, 6.99, 10, "Screws - Robertson"));

        o2.AddProduct(new Product("2 lb hammer ", 10020, 24.99, 1, "Hammer - 2 lb"));
        o2.AddProduct(new Product("5 lb hammer ", 10022, 54.99, 1, "Hammer - 5 lb" ));
        o2.AddProduct(new Product("10 lb hammer ", 10024, 89.99, 1, "Hammer - 10 lb"));

        o3.AddProduct (new Product("Japanese finishing saw ", 12020, 69.99, 2, "Saw - Finishing"));
        o3.AddProduct (new Product("Japanese utility saw ", 12025, 79.99, 2, "Saw - Utility"));
        o3.AddProduct (new Product("Gentleman's saw ", 10220, 127.99, 1, "Saw - Gentlman's"));

        Console.WriteLine("==== Packing Label ====");
        Console.WriteLine(o1.PackingLabel());

        Console.WriteLine("==== Shipping Label ====");
        Console.WriteLine(o1.ShippingLabel());

        Console.WriteLine($"==== Invoice Cost ${o1.OrderCost().ToString("F")} ====");
        Console.WriteLine();

        Console.WriteLine("==== Packing Label ====");
        Console.WriteLine(o2.PackingLabel());

        Console.WriteLine("==== Shipping Label ====");
        Console.WriteLine(o2.ShippingLabel());

        Console.WriteLine($"==== Invoice Cost ${o2.OrderCost().ToString("F")} ====");
        Console.WriteLine();

        Console.WriteLine("==== Packing Label ====");
        Console.WriteLine(o3.PackingLabel());

        Console.WriteLine("==== Shipping Label ====");
        Console.WriteLine(o3.ShippingLabel());

        Console.WriteLine($"==== Invoice Cost ${o3.OrderCost().ToString("F")} ====");
        Console.WriteLine();
    
    }
}