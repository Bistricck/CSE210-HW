using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customers with addresses
        Customer customer1 = new Customer("Mac Johnson", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Bob Dumpster", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "C789", 79.99, 1));
        order2.AddProduct(new Product("Keyboard", "D101", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "E202", 199.99, 1));

        // Display order details
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
            Console.WriteLine(new string('-', 40)); // Separator line
        }
    }
}