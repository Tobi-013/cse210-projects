using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("David Orizu", address1);

        Product product1 = new Product("Laptop", "L123", 999.99m, 1);
        Product product2 = new Product("Mouse", "M456", 25.50m, 2);
        Product product3 = new Product("Keyboard", "K789", 49.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\n====================\n");

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Prestige Igbekele", address2);

        Product product4 = new Product("Phone", "P321", 799.99m, 1);
        Product product5 = new Product("Headphones", "H654", 129.99m, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}