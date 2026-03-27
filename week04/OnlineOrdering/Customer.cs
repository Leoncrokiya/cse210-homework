public class Customer
{
    private string _nameOfCustomer;
    private Address _shippingAddress;

    public Customer(string name, Address address)
    {
        _nameOfCustomer = name;
        _shippingAddress = address;
    }

    public string GetName()
    {
        return _nameOfCustomer;
    }

    public Address GetAddress()
    {
        return _shippingAddress;
    }
}