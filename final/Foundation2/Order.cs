using System;
using System.Collections.Generic;

//public Order Class
public class Order
{
    //Declare field variables: Customer object customer, initialize _products list
    private Customer _customer;
    private List<Product> _products = new List<Product>();


    //Order constructor, Parameters: customer, products list
    //Initialize and set field variables
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }


    //GetCustomerOrderName method, Parameters: none
    //Return _customerName by calling GetCustomerName method
    public string GetCustomerOrderName()
    {
        return _customer.GetCustomerName();
    }


    //CalculateOrderTotalCost method, Parameters: none
    //Return: orderTotal
    public double CalculateOrderTotalCost()
    {
        //Initialize orderTotal to 0
        double orderTotal = 0;

        //Foreach loop, condition: for product in list _products
        foreach (Product product in _products)
        {
            // Call product GetProductTotal method
            //Add productTotalCost to orderTotal.
            orderTotal += product.GetProductTotalCost();
        }


        //If loop, condition: call _customer GetIsFromUSA method
        //if true, customer is from USA, add $5 shipping charge to orderTotal
        //if false, customer not from USA, add $35 shipping charge to orderTotal
        //Return orderTotal
        if (_customer.GetIsFromUsa())
        {
            orderTotal += 5;
        }
        else
        {
            orderTotal += 35;
        }
        return orderTotal;
    }


    //GetPackingLabel method, Parameters: none
    //Return packing label
    public string GetPackingLabel()
    {
        //Initialize packingLabel variable to empty string
        string packingLabel = "";

        //Foreach loop, condition: for product in list _products
        foreach (Product product in _products)
        {
            //Add string for product name and id to packingLabel
            packingLabel += $"Product Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }


    //GetShippingLabel method, Parameters: none
    //Return shipping label by calling _customer GetCustomerName and GetAddressString methods
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetAddressString()}";
    }
}