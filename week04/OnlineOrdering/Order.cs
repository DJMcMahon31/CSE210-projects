using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
       
    private string _shippingLabel;
    private string _packingLabel;

    public Order (string shippingLabel, string packingLabel)
    {   
       
        _shippingLabel = shippingLabel;
        _packingLabel = packingLabel;
    }

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
            return "{_shippingLabel}{_packingLabel}";
        }  
    public string Order1()
    {
        return "{Product}{Customer}";
    }
    public string Customer()
}
    
