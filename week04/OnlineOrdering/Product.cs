using System;

public class Product
{
    private string _name;
    private int _productID;
    private int _quantity;
    private double _price;

    public Product(string name, int productID, int quantity, double price);
    {
        _name = name;
        _productID = productID;
        _quantity = quantity;
        _price = price;

    }
}