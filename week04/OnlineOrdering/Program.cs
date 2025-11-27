using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        ShoppingCart("Jun","123 Acre","Utah","USA","mug",2,"bag",1,"shoes",3);
        ShoppingCart("Arvi","San Juan","Negros","Philippines","bag",2,"mug",3,"shoes",1);


        


    }

    public static void ShoppingCart(string name, string street, string state, string country, string item1, int quantity1,  string item2, int quantity2,  string item3, int quantity3)
    {
        Address address = new Address(street,state,country);
        Customer info = new Customer(name,address.Display());

        Product itemA = new Product(item1, quantity1);
        Order order1 = new Order(item1, itemA.Cart());

        Product itemB = new Product(item2, quantity2);
        Order order2 = new Order(item2, itemB.Cart());

        Product itemC = new Product(item3, quantity3);
        Order order3 = new Order(item3, itemC.Cart());

        List<int> _items = new List<int>();
        int _sum = 0;
        int _shippingFee = 5;

        _items.Add(itemA.Cart());
        _items.Add(itemB.Cart());
        _items.Add(itemC.Cart());

        foreach (int item in _items)
        {
            _sum += item;
        }

        // Address local = new Address(street, state, country);
        if (address.Local(true))
        {
            _shippingFee = 5;
            _sum += _shippingFee;
        }
        else
        {
            _shippingFee = 35;
            _sum += _shippingFee;
        }
        string border = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        Console.WriteLine(border);
        Console.WriteLine($"Name: {info.DisplayName()}");
        Console.WriteLine($"Address: {info.DisplayAddress()}\n");

        Console.WriteLine($"{order1.Label()}\t{quantity1}\t{itemA.Cart()}");
        Console.WriteLine($"{order2.Label()}\t{quantity2}\t{itemB.Cart()}");
        Console.WriteLine($"{order3.Label()}\t{quantity3}\t{itemC.Cart()}");

        Console.WriteLine($"Shipping fee:\t{_shippingFee}");

        Console.WriteLine($"total:\t\t{_sum}");
        Console.WriteLine(border);




    }
    
    // public static void Hi()
    // {
    //     Order total = new Order();
    //     // int _total = total.Calc();
    //     Console.WriteLine(total.Calc());
    // }
}