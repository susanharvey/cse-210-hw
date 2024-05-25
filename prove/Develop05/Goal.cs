using System;

//Abstract base class Goal
public abstract class Goal
{
    //Declare field variabless
    protected string _shortName;
    protected string _description;
    protected int _points;

    //Goal constructor, parameters: name, description, points
    public Goal(string name, string description, int points)
    {
        //Initialize _name, _description, _points
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Getname method, no parameters, getter for name
    //return _shortName
    public string GetName()
    {
        return _shortName;
    }


    //Abstract RecordEvent method, no parameters, no return
    public abstract int RecordEvent(); 

    //Virtual IsComplete method, no parameters, return false
    public virtual bool IsComplete()
    {
        return false;
    }

    //Virtual GetDetailString method, no parameters
    //return string for displaying goal details: checkbox, name, description
    public virtual string GetDetailsString()
    { 
        // ternary operator
        //empty brackets if not complete or x in brackets if complete
        string checkBox = IsComplete() ? "x" : " ";

        return $"[{checkBox}] {_shortName} ({_description})";
    }

    //Virtual GetStringRepresentation method, no parameters
    //file text string to save to and load from a file txt
    //return goal type, name, description and points
    public virtual string GetStringRepresentation()
    {
        //call object GetType
        return $"{GetType()}|{_shortName}|{_description}|{_points}";
    }
}