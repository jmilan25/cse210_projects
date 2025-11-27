public class Order
{
    private string _customerName;
    private string _productName;
    private string _id;
    private bool _shipping;
    private int _sum;
    private List<int> _items = new List<int>();

    public Order(string productName, int item)
    {
        _productName = productName;
        // _total = total;
        _items.Add(item);
    }
    public Order()
    {

    }

    public int Calc()
    {


        foreach (int item in _items)
        {
            _sum += item;
        }
        return _sum;
    }

    public string Label()
    {
        if (_productName == "mug")
        {
            _id = "_mug_";
        }
        else if (_productName == "bag")
        {
            _id = "_bag_";
        }
        else if (_productName == "shoes")
        {
            _id = "_shoes_";
        }
        return _id;

    }
    
    // public int AddItems
    // {
    //     get { return _sum; }
    //     set
    //     {
            
    //     }
    // }
    // public int Cart()
    // {
    //     if (_productName == "mug")
    //     {
    //         _price = 2;
    //     }
    //     else if (_productName == "bag")
    //     {
    //         _price = 5;
    //     }
    //     else if (_productName == "shoes")
    //     {
    //         _price = 10;
    //     }
    //     int sum = _price * _quantity;

    //     return sum;
    // }

    // public string Display()
    // {
        
    // }
    



}