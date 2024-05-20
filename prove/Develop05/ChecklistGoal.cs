using System;

public class ChecklistGoal : Goal
{
    //standard attributes
    //will need to track the number of times it has been completed, 
    //the target number of times the user is striving for, 
    //and the bonus for achieving that target.
   private int _amountCompleted;
   private int _target;
   private int _bonus;

   public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
   {
        // In addition to the standard attributes, 
        //a checklist goal also needs the target 
        //and the bonus amounts. Then, it should 
        //set the amount completed to begin at 0.
    
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

    public override string GetDetailsString()
    {
        /*return the details of a goal that could
        be shown in a list. It should include the 
        checkbox, the short name, and description. */
        // ChecklistGoal goal:overridden to shown the number
        // of times the goal has been accomplished so far.
        return "";
    }

    public override string GetStringRepresentation()
    {
        //provide all of the details of a goal in a way
        //that is easy to save to a file, and then load later.
        return "";
    }
}