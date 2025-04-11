public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    /// <summary>
    /// Construct a new Address with the given street address, city, state, and country.
    /// </summary>
    /// <param name="streetAddress">The street address of the location.</param>
    /// <param name="city">The city of the location.</param>
    /// <param name="state">The state or region of the location.</param>
    /// <param name="country">The country of the location.</param>
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}