using System;

//derived class SimpleGoal
public class SimpleGoal : Goal
{
    //declare _isComplete to track if completed
    private bool _isComplete;

    //SimpleGoal initialization Constructor for derived classes
    //parameters from base: name, description, points
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    { 
        //set _isComplete to false
        _isComplete = false;
    }

    //SimpleGoal initialization Constructor for derived classes
    //parameters: isComplete, from base: name, description, points
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        //initialize _isComplete
        _isComplete = isComplete;
    }

    //override RecordEventMethod, no parameters
    //return _points
    public override int RecordEvent()
    {
        //SimpleGoal Completed, _isComplete = true
        _isComplete = true;

        //Congrats message
        Console.WriteLine("");
        Console.WriteLine("Bravo! You did it!");
        Console.WriteLine("");

        return _points;
    }

    //IsComplete method, no parameters, return _isComplete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    //GetStringRepresention method, no parameters
    //provide all of the details of a goal in a way
    //that is easy to save to a file and then load later.
    //return base GetStringRepresentation plus | true or false
    public override string GetStringRepresentation()
    {
        //provide all of the details of a goal in a way
        //that is easy to save to a file, and then load later.
        return base.GetStringRepresentation() + $"|{_isComplete}";
    }
}