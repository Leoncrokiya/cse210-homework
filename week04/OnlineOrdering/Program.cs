using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Tech Lane", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);

        
        order1.AddProduct(new Product("Wireless Mouse", "M001", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "K002", 89.50, 1));


        
        Address address2 = new Address("456 Gamer Blvd", "Austin", "TX", "USA");
        Customer customer2 = new Customer("Bob Johnson", address2);
        Order order2 = new Order(customer2);

        
        order2.AddProduct(new Product("Gaming Monitor", "D001", 299.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "C015", 15.00, 3));
        order2.AddProduct(new Product("Desk Mat", "M099", 20.00, 1));

        Console.WriteLine("===========================");
        Console.WriteLine("          ORDER 1          ");
        Console.WriteLine("===========================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("===========================");
        Console.WriteLine("          ORDER 2          ");
        Console.WriteLine("===========================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order2.CalculateTotalCost():0.00}\n");
    }
}