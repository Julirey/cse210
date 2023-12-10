using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Address 
{   
    // Attributes
    private string _street;
    private string _city;
    private string _state;

    // Constructors
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }

    // Methods
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}.";
    }
}
