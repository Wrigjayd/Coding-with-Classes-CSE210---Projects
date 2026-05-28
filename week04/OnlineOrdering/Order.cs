using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateOrderTotal()//calculate total including shipping
    {
        double total = 0;
        
        foreach (Product product in _products)
        {
            total += product.CalculateProductTotal();
        }
        double shippingCost = _customer.LivesInUsa() ? 5.00 : 35.00;

        total += shippingCost;

        return total;
    }
    public string CreatePackingLabel()
    {
        string label = "------Packing Label------\n";
        foreach (Product product in _products)
        {
            label +=$"ID: {product.GetProductId()}| Name: {product.GetProductName()}\n";
        }
        return label;
    }
    public string CreateShippingLabel()
    {
        string label = "----- SHIPPING LABEL -----\n";
        label += $"{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }

}