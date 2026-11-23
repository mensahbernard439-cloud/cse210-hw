using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // Order 1: USA customer with 3 products
        Address address1 = new Address("742 Evergreen Terrace", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Hannah Carter", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "PRD-101", 24.50, 2));
        order1.AddProduct(new Product("USB-C Hub", "PRD-204", 39.99, 1));
        order1.AddProduct(new Product("Desk Mat", "PRD-309", 18.00, 1));
        orders.Add(order1);

        // Order 2: International customer with 2 products
        Address address2 = new Address("14 Independence Avenue", "Accra", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Kwame Mensah", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "PRD-410", 89.00, 1));
        order2.AddProduct(new Product("Webcam Cover Pack", "PRD-512", 7.50, 3));
        orders.Add(order2);

        // Display details for each order
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price (incl. ${order.GetShippingCost():F2} shipping): ${order.GetTotalCost():F2}");
            orderNumber++;
        }
        Console.WriteLine("==================================================");
    }
}