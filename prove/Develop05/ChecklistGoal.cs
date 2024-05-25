using System;

//CheckList Goal derived class
public class ChecklistGoal : Goal
{
    //Declare field variables 
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    //CheckListGoal initialization constructor for derived classes
    //parameters: target and bonus and from base: name, description, points
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        //Initialize field variables
        _amountCompleted = 0;
        _isComplete = false;
        _target = target;
        _bonus = bonus;
    }

    // 2nd CheckListGoal initialization constructor for derived classes
    //parameters: isComplete, bonus, amountCompleted, target and from base: name, description, points
    public ChecklistGoal(string name, string description, int points, bool isComplete, int bonus, int amountCompleted, int target) : base(name, description, points)
    {
        //Initialize field variables
        _amountCompleted = amountCompleted;
        _isComplete = isComplete;
        _target = target;
        _bonus = bonus;
    }

    //Override RecordEvent method, no parameters
    //return points + bonus if target reached, otherwise return points
    public override int RecordEvent()
    {
        //Increase amountCompleted by 1 everytime RecordEvent is called.
        _amountCompleted += 1;

        //If loop, condition: amountcompleted = target
        if (_amountCompleted == _target)
        {
            //goal is complete
            _isComplete = true;

            //Congrats message
            Console.WriteLine("It's about both the journey and the destination! Enjoy your success!!");
            Console.WriteLine("");

            return _points + _bonus;
        }
         //Congrats message
        Console.WriteLine("");
        Console.WriteLine("You deserve every exciting and wonderful thing about this!");
        Console.WriteLine("");

        return _points;
    }

    //Override IsComplete method, no parameters, return _isComplete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    //Override GetDetailsString method, no parameters
    //return base GetDetailsString and amountCompleted/target
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" --Currently Completed: {_amountCompleted}/{_target}";
    }

    //Override GetStringRepresentation method, no parameters
    //return base GetStringRepresentation and isCompplete, bonus, amountCompleted and target.
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_isComplete}|{_bonus}|{_amountCompleted}|{_target}";
    }
}