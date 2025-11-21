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
    
