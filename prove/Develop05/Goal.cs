using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {

    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        //return the details of a goal 
        //that can be shown in a line, 
        //include check box, name, description
        return "";
    }

    public abstract string GetStringRepresentation();
}