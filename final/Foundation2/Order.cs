using System;
using System.Collections.Generic;
using System.Text;

public class Order 
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private Customer _customer;
    private List<Product> _products;

    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

    }  
    public double TotalCost()
    {
        double total = 0;
       
        // We call the funcion from Product to know the total 
        // and sum the cost of the travel
        foreach (Product product in _products)
        {
            total += product.ProductTotal();
        }

        string country = _customer.GetDirection();
        if (country ==  "USA")
        {
            total += 5;
        }

        else
        {
            total += 35;
        }
        
        return total;
    }
       
    public string PackingLabel()
    {
        // Will be recalculated each time it is called.        
        string ListProducts = "";
        Console.WriteLine("Orders Products:");
        foreach (Product product in _products)
        {
            string label = product.ProductName();
            string ID = product.ProductID();
            ListProducts += "   "+ label + $" (ID: {ID}) \n";
        }
        return ListProducts;
    }
    

    public string ShippingLabel()
    {
        // Will be recalculated each time it is called.        
        Customer customer = _customer;
        string ship = "Name:" + customer.GetName() + "\n" + 
        "Address:" + customer.GetAddress();
        return ship;
    }
}