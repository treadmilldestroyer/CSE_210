using System;
using System.Collections.Generic;
class Order
{
    private List<Product> _productsList;
    private Customer _customerInfo;
    private double _orderTotal;


    public Order(List<Product> productsList, Customer customerInfo, double orderTotal = 0.0)
    {
        _productsList = productsList;
        _customerInfo = customerInfo;
        _orderTotal = orderTotal;
    }

    public void AddProducts(Product product)
    {
        _productsList.Add(product);
    }

    public string CalculateOrderTotal()
    {
        // If CustomerInUSA is true, shippingCost= $5
        // Else shipppingCost= $35
        double shippingCost = _customerInfo.CustomerInUSA() ? 5.0 : 35.0;
        
        foreach (Product product in _productsList)
        {
            double totalProductCost = product.CalculateTotalProductCost();
            _orderTotal += totalProductCost;
        }
        _orderTotal += shippingCost;
        return $"Order Total: ${_orderTotal}";
    }

    // List the name of the product and the product id of every product in the order.
    public string PackingLabel()
    {
        string title = "Packing Label:\n";
        foreach (Product product in _productsList)
        {
            title += $"Product:{product.GetProductName()} - ID:{product.GetProductID()} x{product.GetQuantity()}\n";
        }
        return title;
    }

    // List the name and address of the customer.
    public string ShippingLabel()
    {
        string title = "Shipping Label:\n";
        title += _customerInfo.GetCustomerName() + "\n";
        title += _customerInfo.CustomerAddress.ToString() + "\n";
        return title;
    }
}