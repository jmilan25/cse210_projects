using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ShoppingCart();


    }
    
    public static void ShoppingCart()
    {

        Product item1 = new Product("mug", 2);
        Console.WriteLine(item1.Cart());
        Order order1 = new Order("mug",item1.Cart());

        Product item2 = new Product("bag", 1);
        Console.WriteLine(item2.Cart());
        Order order2 = new Order("bag", item2.Cart());

        Product item3 = new Product("shoes", 3);
        Console.WriteLine(item3.Cart());
        Order order3 = new Order("shoes", item3.Cart());
        
        

        
        
    }
}