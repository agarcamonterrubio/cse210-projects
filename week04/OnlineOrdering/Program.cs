using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear direcciones de clientes
        Address address1 = new Address("1234 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("56 Maple Ave", "Toronto", "ON", "Canada");

        // Crear clientes
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Crear productos
        Product product1 = new Product("Laptop", 101, 800.00, 1);
        Product product2 = new Product("Smartphone", 102, 600.00, 2);
        Product product3 = new Product("Headphones", 103, 50.00, 3);

        // Crear órdenes
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Mostrar las etiquetas y el precio total para cada pedido
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        // Mostrar etiquetas de empaque y envío
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());

        // Mostrar precio total
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine();  // Línea en blanco para separar pedidos
    }
}
