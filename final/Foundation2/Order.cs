using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{   
    // Attributes
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // Constructors
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public Order(string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
    }
    
    // Methods
    public string GetPackingLabel()
    {
        StringBuilder s = new StringBuilder();
        foreach (Product p in _products)
        {
            s.AppendLine($"{p.GetPackingInfo()}");
        }

        return s.ToString();
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingInfo();
    }

   
    public int GetProductCost()
    {
        int cost = 0;
        foreach (Product p in _products)
        {
            cost += p.GetPrice();
        }
        return cost;
    }
    public int GetShippingCost()
    {   
        if (_customer.InUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public void AddProduct(string name, int price, string id, int quantity)
    {
        Product product = new Product(name, price, id, quantity);
        _products.Add(product);
    }
}
