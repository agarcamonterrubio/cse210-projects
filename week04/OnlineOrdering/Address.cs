public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Propiedades de solo lectura
    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string State { get { return state; } }
    public string Country { get { return country; } }

    // Método para verificar si la dirección está en los EE.UU.
    public bool IsInUSA()
    {
        return country == "USA";
    }

    // Método para obtener la dirección completa como un solo string
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}
