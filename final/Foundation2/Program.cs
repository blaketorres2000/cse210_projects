using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a customer
        Address customerAddress = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer = new Customer("John Doe", customerAddress);

        // Create some products
        Product product1 = new Product("Product 1", "P001", 10.99m, 2);
        Product product2 = new Product("Product 2", "P002", 5.99m, 3);

        // Create an order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Calculate total cost and print labels
        decimal totalCost = order.GetTotalCost();
        string packingLabel = order.GetPackingLabel();
        string shippingLabel = order.GetShippingLabel();

        Console.WriteLine("Total Cost: $" + totalCost);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);
    }
}
