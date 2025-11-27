public class Customer
{
    private string _name;
    private string _address;
    private bool _local;
    // Address _addressLine = new Address();
    public Customer(string name, string address)
    {
        _name = name;
        _address = address;
        // _local = local;
    }

    public bool Local(bool local)
    {
        if (_local is true)
        {
            local = true;
        }

        return local;
    }

    public string Display()
    {
        // Address addressLine = new Address();
        string text = $"{_name} - {_address}";
        return text;
    }
    public string DisplayName()
    {
        // Address addressLine = new Address();
        string text = $"{_name}";
        return text;
    }
    public string DisplayAddress()
    {
        // Address addressLine = new Address();
        string text = $"{_address}";
        return text;
    }
    

}