public class Customer
{
    private string _name;
    private Address _address;
    /// <summary>
    /// Constructs a new Customer with the specified name and address.
    /// </summary>
    /// <param name="name">The name of the customer.</param>
    /// <param name="address">The address of the customer.</param>

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isInUSA()
    {
        return _address.isInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}