using System;
using System.Diagnostics.Contracts;

public class Product
{
    private string _customerName;
    private int _productID;
    private int _quantity;
    private double _price;
    private string _packingText;

    public Product(string customerName, int productID, double price, int quantity, string packingText)
    {
        _customerName = customerName;
        _productID = productID;
        _quantity = quantity;
        _price = price;
        _packingText = packingText;

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

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingText()
    {
        return _packingText;
    }

    public void SetPackingText(string packingText)
    {
        _packingText = packingText;
    }
}