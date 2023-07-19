using System;

// Address class
public class Address
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }  

    // Get Address of Customer 
    public string GetFulldAddress()
    {
        string _address = $"{_street} - {_city}, {_state}({_country})";
        return _address;
    }

}