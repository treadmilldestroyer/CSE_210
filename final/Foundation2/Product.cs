class Product 
{
    private string _productName;
    private double _productId;
    private double _pricePerUnit;
    private int _quantity;


    public Product (string productName, double productId, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public double GetProductID()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string DisplayProduct()
    {
        return $"Product: {_productName}\nProduct ID: {_productId}\nPrice: ${_pricePerUnit}\nQuantity: {_quantity}";
    }

    public double CalculateTotalProductCost()
    {
        return _pricePerUnit * _quantity; 
    }
}