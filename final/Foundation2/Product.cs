using System;
using System.Collections.Generic;
using System.Text;

// We add public to the general class of the Entry 
// to may be accessible to the other programs
public class Product
{

    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private string _name, _id;
    private double _totalPrice,_price;
    private int _quantity;
    public Product (string name, string id, double price, int quantity)
    {
        _name= name;
        _id = id;
        _price = price;
        _quantity = quantity;
   
    }

    // This is how is gonna we displey the id, name, price, quantity and the total for the user in the system(Program.cs)
    public string ProductID()
    {
        return _id;
    }
    public string ProductName()
    {
        return _name;
    }
    public double ProductPrice()
    {
        return _price;
    }
    public int ProductQuantity()
    {
        return _quantity;
    }
    public double ProductTotal()
    {
        _totalPrice = _price * _quantity ;
        return _totalPrice;
    }
}