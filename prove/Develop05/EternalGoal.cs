using System;

//EternalGoal derived class
public class EternalGoal : Goal
{
    //EternalGoal initialization constructor for derived classes
    //parameters from base: name, description, points
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    //Override RecordEvent method, no parameters, return points
    public override int RecordEvent()
    {
        //Congrats message
        Console.WriteLine("");
        Console.WriteLine("You're a true inspiration! Keep going!");
        Console.WriteLine("");

        return _points;
    }
}