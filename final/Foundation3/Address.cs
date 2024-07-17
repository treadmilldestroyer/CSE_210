public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _zipCode;


    public Address(string streetAddress, string city, string stateProvince, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _zipCode = zipCode;
    }

    // public string GetAddress()
    // {
    //     return $"{_streetAddress}\n{_city}, {_stateProvince}, {_zipCode}";
    // }
    public override string ToString()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_zipCode}";
    }

}