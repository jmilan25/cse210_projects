public class Order
{
    private string _customerName;
    private string _productName;
    private string _id;
    private bool _shipping;
    private int _sum;
    private int _total;
    private List<int> _items = new List<int>();

    public Order(string productName, int item)
    {
        _productName = productName;
        // _total = total;
        _items.Add(item);
    }

    public void Calc()
    {

        foreach (int item in _items)
        {
            _sum += item;
        }

    }
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