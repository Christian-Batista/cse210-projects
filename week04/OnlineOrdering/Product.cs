public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    /// <summary>
    /// Construct a new Product with the given name, product ID, price, and quantity.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="productID">The ID of the product.</param>
    /// <param name="price">The price of one unit of the product.</param>
    /// <param name="quantity">The number of units of the product being ordered.</param>
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }
}