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

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
    {
        return _customer.LivesInUsa() ? 5.0 : 35.0;
    }

    public double GetTotalCost()
    {
        double productsTotal = 0.0;
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }
        return productsTotal + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (Product product in _products)
        {
            sb.AppendLine($"  - {product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Shipping Label:");
        sb.AppendLine($"  {_customer.GetName()}");
        string[] addressLines = _customer.GetAddress().GetFormattedAddress().Split('\n');
        foreach (string line in addressLines)
        {
            sb.AppendLine($"  {line}");
        }
        return sb.ToString().TrimEnd();
    }
}