using System;

//Creativity/enhancement: I added some user input guards, a guard and message for if the user
//records a goal already completed, congrats messages for recording each type of goal,
//and special congrats messages for reaching 5000, or 10000 points.

//Congrats Message Source: https://www.americangreetings.com/inspiration/what-to-write/congratulations-messages
class Program
{
    static void Main(string[] args)
    {
        //Initialize new GoalManager run, call the start method.
        //no parameters
        GoalManager run = new();
        run.Start();
    }
}