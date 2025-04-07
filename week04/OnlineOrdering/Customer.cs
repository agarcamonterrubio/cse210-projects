public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Propiedades de solo lectura
    public string Name { get { return name; } }
    public Address CustomerAddress { get { return address; } }

    // Método para verificar si el cliente vive en los EE.UU.
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}
