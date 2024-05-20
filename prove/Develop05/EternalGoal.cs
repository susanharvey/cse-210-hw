using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

     public override void RecordEvent()
   {
    //RecordEvent event:mark what has been accomplished
    /*This method should do whatever is necessary
    for each specific kind of goal, such as marking 
    a simple goal complete and adding to the number
    of times a checklist goal has been completed.
    It should return the point value associated
    with recording the event (keep in mind that
    it may contain a bonus in some cases if a 
    checklist goal was just finished, for example).*/
   }

    public override bool IsComplete()
    {
        //should return true if the goal is completed.
        //. The way you determine if a goal is complete
        // is different for each type of goal. 
        return true; //or false ?
    }

    public override string GetStringRepresentation()
    {
        //provide all of the details of a goal in a way
        //that is easy to save to a file, and then load later.
        return "";
    }
}