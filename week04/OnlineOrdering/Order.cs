using System;

public class Order
{
    private string _productName;
    private int _productID;
    private double _price;
    private string _address;
    private string _packingLabel;

    public Order(string productName, int productID, double price, string address, string packingLabel)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _address = address;
        _packingLabel = packingLabel;

    }
}