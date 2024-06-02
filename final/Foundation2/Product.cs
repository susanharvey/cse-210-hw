using System;

//Public Product Class
public class Product
{
    //Declare field variables: _productName, _id, _price, _quantity
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;


    //Product Constructor, Parameters: productName, id, price, quantity
    //Initialize field variables
    public Product(string productName, string id, double price, int quantity)
        {
            _productName = productName;
            _id = id;
            _price = price;
            _quantity = quantity;
        }


        //getProductName method, Parameters: none, Return _productName
        public string GetProductName()
        {
            return _productName;
        }


        //GetProductID method, Parameters: none, Return _id
        public string GetProductId()
        {
            return _id;
        }


        //GetProductTotalCost method, Parameters: none
        //Return _price * _quantity 
        //Calculate product total and return it
        public double GetProductTotalCost()
        {
            return _price * _quantity;
        }
}