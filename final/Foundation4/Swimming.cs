using System;
using System.Reflection;

//Public Swimming class derived from Activity class.
public class Swimming : Activity
{
    //Declare field variables: _numberOfLaps
    private double _numberOfLaps;


    //Swimming constructor, Parameters: type, date, lengthInMinutes
    //Inherits and initializes type, date, lengthInMinutes
    //Inititialzes _numberOfLaps
    public Swimming(string type, string date, int lengthInMinutes, double numberOfLaps ) : base(type, date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }


    
    //Override base GetDistance method, Parameters: none
    //Return _numberOfLaps * 50 / 1000
    //to calculate the swimming distance
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;  //km
    }


    //Override base GetSpeed method, Parameters: none
    //Return GetDistance() / _lengthInMinutes * 60
    //Calling the GetDistance method and calculate the swimming speed
    public override double GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60; //per hour
    }


    //Override base GetPace method, Parameters: none
    //Return _lengthInMinutes / GetDistance()
    //Calling the GetDistance method and calculate the swimming pace
    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); //min per km
    }
}