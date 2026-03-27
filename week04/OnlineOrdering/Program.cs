using System;

class Program
{
    static void Main(string[] args)
    {

        // Addresses
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        // Customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Jane Smith", addr2);

        // Products
        Product prod1 = new Product("Laptop", "P001", 1200m, 1);
        Product prod2 = new Product("Mouse", "P002", 25m, 2);
        Product prod3 = new Product("Keyboard", "P003", 50m, 1);
        Product prod4 = new Product("Monitor", "P004", 300m, 1);

        // Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);

        // Display orders
        Order[] orders = { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
            Console.WriteLine("-------------------------------\n");
        }
    }
}