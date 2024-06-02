using System;

//Public Address Class
public class Address
{
    //Declare field variables: _street, _city, _stateProvince, _country
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;


    //Address Constructor, Parameters: street, city, stateProvince, country
    //Set field variables
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }


    //IsUsa bool method, Parameters: none, Return: true or false
    //Is Customer a USA citizen?
    public bool IsUsa() 
    {
        return _country == "USA" ? true : false;
    }


    //GetAddressString method, Parameters: none
    //Return: string address for shipping label in maiing format
    public string GetAddressString()
    {
        return $"{_street}\n{ _city}, {_stateProvince}\n{_country}\n";
    }  
}