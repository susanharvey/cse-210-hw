using System;

//Create BreathingActivity derived from Activity class.
public class BreathingActivity : Activity
{
    //BreathingActivity constructor, no parameters.
    //Inherits and initializes name, description, and duration fields.
    public BreathingActivity() 
    {
        _name = "Breathing";
        _description = "This activity will help you relax by breathing in and out slowly.\nClear your mind and focus on your breathing.";
        _duration = 30;
    }

    //Breathing run method, no parameters, no return.
    //Runs the breathing activity.
    public void Run() 
    {
        //Calls the base DisplayStartMessage, no parameter.
        base.DisplayStartMessage();

        //Call DateTime and sets start and end times for activity duration.
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_duration);

        //While loop, condition: current time < end time.
        while (DateTime.Now < endTime)
        {
            //Display breathe in and breathe out with countdown timer
            //for duration chosen by user.
            Console.Write("Breathe in....");
            base.ShowCountDown(3);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            base.ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        //Call base DislayEndMessage method, no parameter.
        base.DisplayEndingMessage();
    }
}