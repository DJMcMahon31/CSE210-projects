using System.Net.Sockets;

using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public string CustomerName {get { return _customerName; } }
    public Address Address {get{return _address;}}

    /*public string DisplayText
    {
        get
        {
            return $"{_customerName}\n{_address.DisplayText}";
        }
    } */

    public Customer(string customerName, Address address)
    {
    _customerName = customerName;
    _address = address;
    }
    public bool inUSA()
    {
       return _address.inUSA();
    }
    public string GetDisplayText()
    {
        return $"{_customerName}\n{_address.GetDisplayText()}";
    }
    

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }



}