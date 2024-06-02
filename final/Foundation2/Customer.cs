using System;

//public Customer Class
public class Customer
{
    //Declares field variables: _customerName, _customerAddress
    private string _customerName;
    private Address _customerAddress;


    //Custmer constructor, Parameters: customerName, customerAddress
    //Initialize field variables
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }


    //GetCustmerAddress method, Parameters: none
    //Return _customerAddress
    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }


    //GetCustmerName method, Parameters: none
    //Return _customerName
    public string GetCustomerName()
    {
        return _customerName;
    }


    //GetIsFromUsa bool method, Parameters: none
    //Return true or false by calling _customerAddress.IsUsa()
    public bool GetIsFromUsa()
    {
        return _customerAddress.IsUsa();
    }
}