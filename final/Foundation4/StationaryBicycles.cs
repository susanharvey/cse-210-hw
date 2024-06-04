using System;

//Public StationaryBicycles class derived from Acivity class.
public class StationaryBicycles : Activity
{
    //Declare field variables: _speed
    private double _speed;


    //StationaryBicycles constructor, Parameters: type, date, lengthInMinutes, speed
    //Inherits and initializes type, date, lengthInMinutes
    //Inititialzes speed
    public StationaryBicycles(string type, string date, int lengthInMinutes, double speed) : base(type, date, lengthInMinutes)
    {
        _speed = speed;
    }


    //Override base GetDistance method, Parameters: none
    //Return _speed * _lengthInMinutes
    //to calculate the stationary bike distance
    public override double GetDistance() //km
    {
        return _speed * _lengthInMinutes;
    }


    //Override base GetSpeed method, Parameters: none
    //Return _speed
    public override double GetSpeed() //km per hour
    {
        return _speed;
    }


    //Override base GetPace method, Parameters: none
    //Return 60 / _speed
    //to calculate the stationary bike pace
    public override double GetPace() //mins per km
    {
        return 60 / _speed;
    }
}