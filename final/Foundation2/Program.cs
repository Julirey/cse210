using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order o1 = new Order("John Doe", "4470 Saturn Rd", "Garland", "Texas", "USA");
        o1.AddProduct("Blue Shirt - Size M", 14, "AB112", 2);
        o1.AddProduct("Dark Blue Jeans - Size L", 10, "C112T", 3);
        o1.AddProduct("Black Tie", 5, "A2299", 1);
        o1.AddProduct("Gray Sweater - Size M", 12, "G57G8", 1);
        orders.Add(o1);

        Order o2 = new Order("Jane Doe", "2119 Boulevard Ste-Geneviève", "Chicoutimi", "Quebec", "CAN");
        o2.AddProduct("Red Skirt - Size S", 10, "N29CC", 1);
        o2.AddProduct("White Jacket - Size M", 16, "2389L", 1);
        o2.AddProduct("Black Scarf", 8, "3939I", 1);
        o2.AddProduct("White Socks", 2, "JE003", 6);
        orders.Add(o2);

        foreach (Order o in orders)
        {
            Console.WriteLine("Order:");
            Console.WriteLine();
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Products: ${o.GetProductCost()}");
            Console.WriteLine($"Shipping: ${o.GetShippingCost()}");
            Console.WriteLine($"Total:    ${o.GetProductCost() + o.GetShippingCost()}");
            Console.WriteLine("----------------------------------------");
        }
    }
}