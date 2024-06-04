using System;

//Public Swimming class derived from Activity class.
public class Swimming : Activity
{
    //Declare field variables: _numberOfLaps
    private double _numberOfLaps;


    //Swimming constructor, Parameters: type, date, lengthInMinutes, numberOfLaps
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
    //Calls the GetDistance method and calculates the swimming speed
    public override double GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60; //km per hour
    }


    //Override base GetPace method, Parameters: none
    //Return _lengthInMinutes / GetDistance()
    //Calls the GetDistance method and calculates the swimming pace
    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); //min per km
    }
}