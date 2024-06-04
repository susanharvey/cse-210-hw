using System;

//Public Activity base class
public abstract class Activity
{
    //Declare field variables: _activityType, _date, _lengthInMinutes
    protected string _activityType;
    protected string _date;
    protected int _lengthInMinutes;


    //Activity constructor, Parameters: type, date, lengthInMinutes
    //Initializes type, date, and lengthInMinutes
    public Activity(string type, string date, int lengthInMinutes)
    {
        _activityType = type;
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }


    //Virtual GetDistance method, Parameters: none
    //Return 0
    public virtual double GetDistance()
    {
        return 0;
    }


    //Virtual GetSpeed method, Parameters: none
    //Return 0
    public virtual double GetSpeed()
    {
        return 0;
    }


    //Virtual GetPace method, Parameters: none
    //Return 0
    public virtual double GetPace()
    {
        return 0;
    }


    //GetSummary method, Parameters: none
    //Return a string activity summary
    //Listing the date, activity title, and lengthInMinutes
    //Listing distance, speed and pace by calling the GetDistance, GetSpeed, and GetPace methods
    //Round decimals to 2 places, format distance, speed, and pace to 1 or 2 decimal places
    public string GetSummary()
    {
        return $"{_date} {_activityType}({_lengthInMinutes} min): Distance: {Math.Round(GetDistance(),2).ToString("0.0##")} km, Speed: {Math.Round(GetSpeed(),2).ToString("0.0##")} kph, Pace: {Math.Round(GetPace(),2).ToString("0.0##")} min per km";
    }
}