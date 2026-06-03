using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Customer usaCustomer = new Customer("Tony Stark", usaAddress);
        Order order1 = new Order(usaCustomer);

        Product p1 = new Product("Arc Reactor Core", 101, 250.00, 1);
        Product p2 = new Product("Red Spray Paint", 102, 12.50, 3);
        
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Display Order 1 Results
        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER #1                 ");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine($"Total Cost (Inc. USA Shipping): ${order1.CalculateOrderTotal():F2}");
        Console.WriteLine();


        // --- Order 2: International Customer ---
        Address intlAddress = new Address("456 Bond St", "London", "England", "UK");
        Customer intlCustomer = new Customer("James Bond", intlAddress);
        Order order2 = new Order(intlCustomer);

        Product p3 = new Product("Laser Watch", 201, 500.00, 1);
        Product p4 = new Product("Tuxedo Suit", 202, 120.00, 2);
        Product p5 = new Product("Martini Shaker", 203, 25.00, 1);

        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Display Order 2 Results
        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER #2                 ");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine($"Total Cost (Inc. Intl Shipping): ${order2.CalculateOrderTotal():F2}");
        Console.WriteLine("========================================");
    }

}
