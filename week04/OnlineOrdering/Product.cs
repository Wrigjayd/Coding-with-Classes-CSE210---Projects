public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productName, int productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductId()
    {
        return _productID;
    }
    public double CalculateProductTotal()
    {
        return _productPrice * _productQuantity;
    }

} 