using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Propiedad para agregar productos al pedido
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Método para calcular el precio total del pedido
    public double GetTotalPrice()
    {
        double total = 0;

        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Agregar costo de envío basado en el país
        double shippingCost = customer.LivesInUSA() ? 5.0 : 35.0;
        total += shippingCost;

        return total;
    }

    // Método para obtener la etiqueta de empaque
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    // Método para obtener la etiqueta de envío
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.CustomerAddress.GetFullAddress()}";
    }
}
