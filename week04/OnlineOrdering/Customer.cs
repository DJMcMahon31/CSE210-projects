using System.Net.Sockets;

using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
    _customerName = customerName;
    _address = address;
    }
    public bool inTheUSA()
    {
       return _address.LivesInUSA();
    }
    public string GetDisplayText()
    {
        return $"{_customerName}\n{_address.GetDisplayText()}";
    }
}