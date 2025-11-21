using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
       
    private string _shippingLabel;
    private string _packingLabel;
    private string _productName;
    private int _productID;
    private double _price;
    private string _address;
    private string _customer;



    public Order(string productName, int productID, double price, string address, string packingLabel, string customer)
{
    _productName = productName;
    _productID = productID;
    _price = price;
    _address = address;
    _packingLabel = packingLabel;
    _customer = customer;

    public string ShippingLabel()
    {
        return _customer.DisplayText();
    }

    public double OrderCost()
    {
        double output = 0;
        foreach (Product p in _products)
        {
            output += p.ExtendedPrice();
        }

        //add shipping
        if (_customer.LivesInUSA())
        {
            output += 5.0;
        }
        else
        {
            output += 35.0;
        }
        return output;
    }

    public string PackingLabel()
    {
        string output = "";
        foreach (Product p in _products)
        {
            output += p.PackingText();
        }
        return output;
    }
    public string GetDisplayText()
        {
            return $"{_productName} (ID: {_productID}) - ${_price:F2}\nShip to: {_address}\nLabel: {_packingLabel}";
        }  
    
    /*public string AddProduct()
    {
        return;
    }
    */
    }
    
}
    
