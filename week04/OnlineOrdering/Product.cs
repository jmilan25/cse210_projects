public class Product
{
    private string _item;
    private int _quantity;
    private int _price;

    // List<string> _product = new List<string>();
    // string bag = _product.Add("bag");

    public Product(string item)
    {
        _item = item;
        _quantity = 1;
    }
    public Product(string item, int quantity)
    {
        _item = item;
        _quantity = quantity;
    }

    // public int Cart()
    // {
    //     return _price * _quantity; ;
    // }
    

    public int Cart()
    {
        if (_item == "mug")
        {
            _price = 2;
        }
        else if (_item == "bag")
        {
            _price = 5;
        }
        else if (_item == "shoes")
        {
            _price = 10;
        }

        int sum = _price * _quantity;
        // Console.WriteLine($"{_item} * {_quantity} = {sum}");
        return sum;
    }

}