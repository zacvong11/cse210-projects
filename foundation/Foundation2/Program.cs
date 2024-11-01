using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

       
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

       
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.00, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MON789", 300.00, 2));
        order2.AddProduct(new Product("Keyboard", "KBD101", 50.00, 1));

       
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
