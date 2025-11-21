using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
       

    private Customer _customer;
    private List<Product> _product = new List<Product>();



    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _product = new List<Product>();        
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
    
    
    
}
    
