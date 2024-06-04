using System;

//Public Running class derived from Activity class.
public class Running : Activity
{
    //Declare field variables: _distance
    private double _distance;


    //Running constructor, Parameters: type, date, lengthInMinutes, distance
    //Inherits and initializes type, date, lengthInMinutes
    //Inititialzes distance
    public Running(string type, string date, int lengthInMinutes, double distance ) : base(type, date, lengthInMinutes)
    {
        _distance = distance;
    }


    //Override base GetDistance method, Parameters: none
    //Return _distance
    public override double GetDistance() // km 
    {
        return _distance;
    }


    //Override base GetSpeed method, Parameters: none
    //Return (_distance / _lengthInMinutes) * 60
    //to calculate the running speed
    public override double GetSpeed() //km per hour
    {
        return (_distance / _lengthInMinutes) * 60;
    }


    //Override base GetPace method, Parameters: none
    //Return _lengthInMinutes / _distance
    //to calculate the running pace
    public override double GetPace() //mins per km
    {
        return _lengthInMinutes / _distance;
    }
}