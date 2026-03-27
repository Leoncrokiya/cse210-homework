using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetProductTotal();
        }
        return totalCost;
    }

    // Returns a string containing product names and details
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("--- PACKING LABEL ---");
        foreach (Product product in _products)
        {
            label.AppendLine(product.GetProductDetails());
        }
        return label.ToString();
    }

    // Returns a string containing the customer's name and full address
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("--- SHIPPING LABEL ---");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFullAddress());
        return label.ToString();
    }
}