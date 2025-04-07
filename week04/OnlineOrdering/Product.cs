public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Propiedades de solo lectura
    public string Name { get { return name; } }
    public int ProductId { get { return productId; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    // Método para calcular el costo total del producto
    public double GetTotalCost()
    {
        return price * quantity;
    }
}
