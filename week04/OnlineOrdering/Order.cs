using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
       

    private string _customer;
    private List<Product> _product = new List<Product>();



    public Order(string customer, List<Product> product)
    {
        _customer = customer;
        _product = product;        
    }


    public string ShippingLabel()
    {
        return _customer.DisplayText();
    }

    public double OrderCost()
    {
        double output = 0;
        foreach (Product p in _product)
        {
            output += p.totalPrice();
        }

        //add shipping
        if (_customer.inUSA())
        {
            output += 5;
        }
        else
        {
            output += 35;
        }
        return output;
    }

    public string PackingLabel()
    {
        string output = "";
        foreach (Product p in _product)
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
    
