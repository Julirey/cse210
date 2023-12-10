using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{   
    // Attributes
    private string _name;
    private Address _address;

    // Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }
    
    // Methods
    public bool InUSA()
    {
        return _address.InUSA();
    }
    public string GetShippingInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {_name}");
        sb.AppendLine($"Address: {_address.GetAddress()}");

        return sb.ToString();
    }
}
