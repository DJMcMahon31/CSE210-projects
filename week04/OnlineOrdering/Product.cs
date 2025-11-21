using System;
using System.Diagnostics.Contracts;

public class Product
{
    private string _customerName;
    private int _productID;
    private int _quantity;
    private double _price;

    public Product(string customerName, int productID, double price, int quantity)
    {
        _customerName = customerName;
        _productID = productID;
        _quantity = quantity;
        _price = price;

    }
    /*public string GetDisplayText()
    {
        return "{_name}{_productID}{_quantity}{_price}";
    }
    */
    public double totalPrice()
    {
        return _quantity * _price;
    } 

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price; 
    }
    
    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    
    public int GetProductID()
    {
        return _productID;
    }

}