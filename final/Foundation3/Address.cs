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


    //GetAddressString method, Parameters: none
    //Return: string address
    public string GetAddressString()
    {
        return $"{_street}\n{ _city}, {_stateProvince}\n{_country}";
    }  
}