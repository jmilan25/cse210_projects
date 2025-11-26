public class Address
{
    private string _street;
    private string _state;
    private string _country;
    public Address(string street, string state, string country)
    {
        _street = street;
        _state = state;
        _country = country;
    }

    public bool Local(bool local)
    {
        if (_country == "USA")
        {
            local = true;
        }
        return local;
    }

    public string Display()
    {
        return $"{_street}, {_state}, {_country}";
    }
}