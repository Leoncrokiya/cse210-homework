public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductTotal()
    {
        return _price * _quantity;
    }

    public string GetProductDetails()
    {
        return $"{_productName} (ID: {_productId}) - Price: ${_price:0.00} - Qty: {_quantity}";
    }
}