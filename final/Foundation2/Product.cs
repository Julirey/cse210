using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{   
    // Attributes
    private string _name;
    private int _price;
    private string _productId;
    private int _quantity;

    // Constructors
    public Product(string name, int price, string productId)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = 1;
    }
    public Product(string name, int price, string productId, int quantity)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = quantity;
    }
    
    // Methods
    public int GetPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_quantity}x {_name} | [{_productId}]";
    }
}
