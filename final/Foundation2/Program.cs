using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address customer1Address = new Address("123 Boulevard", "Salt Lake City", "Utah", "USA");
        Customer customer1 = new Customer("Adam Bishop", customer1Address);
        List<Product> productsList1 = new List<Product>();
        
        Product product1 = new Product("Apple", 11114, 0.50, 12);
        Product product2 = new Product("Charmin", 11117, 19.99, 1);
        Product product3 = new Product("Flowers", 11234, 5.99, 2);
    
        Order order1 = new Order(productsList1, customer1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.CalculateOrderTotal());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // Order 2
        Address customer2Address = new Address("321 Maipo", "Independencia", "Santiago", "Chile");
        Customer customer2 = new Customer("Santiago Martinez", customer2Address);
        List<Product> productsList2 = new List<Product>();

        Product product4 = new Product("RedBull", 11115, 2.50, 2);
        Product product5 = new Product("Candle", 11124, 10.99, 3);
        Product product6 = new Product("Qunioa", 11222, 2.50, 5);

        Order order2 = new Order(productsList2, customer2);
        order2.AddProducts(product4);
        order2.AddProducts(product5);
        order2.AddProducts(product6);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.CalculateOrderTotal());
    }
}