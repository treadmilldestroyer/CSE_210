class Customer 
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address CustomerAddress
    {
        get { return _address; }
        set { _address = value; }

    }
    
    public bool CustomerInUSA()
    {
        if (_address.InUSA())
        {
           return true;
        }
        else
        {
            return false;
        }
    }
}
