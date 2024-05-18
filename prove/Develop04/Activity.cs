using System;
using System.Collections.Generic;
using System.Threading;

//Create base class, Activity
public class Activity
{
    //Declare base class fields.
    //Set to protected for use by derived classes.
    //AnimationStrings list set to private.
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _animationStrings;

    //Activity constructor, no parameters.
    //Initializes name, description, and duration,
    //and animationStrings list.
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;

        _animationStrings = new(){"|", "/", "-", "\\"};
    }

    //DisplayStartMessage method, no parameters, no return.
    //Displays derived class activity's start message, gets user input for duration,
    //and displays get ready message with spinner. 
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Clear console for "get ready' message.
        Console.Clear(); 

        Console.WriteLine("Get Ready.....");

        //Call ShowSpinner method, parameter 3. 
        ShowSpinner(3);

        Console.WriteLine(); 
    }

    //DisplayEndingMessage method, no parameters, no return.
    //Displays derived class activity's ending message with spinners.
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    //ShowSpinner method, parameter: spinner seconds, no return.
    //Create pausing spinner.
    public void ShowSpinner( int spinnerSeconds)
    {
        //Call DateTime, set start and end times for spinner.
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(spinnerSeconds);

        //Initilaze index i.
        int i = 0;

        //While Loop, condition: current time < end time.
        //Creates pausing spinner with a flexible duration of seconds
        while (DateTime.Now < endTime)
        {
            //Sets s to animation strings at i index,
            //displays animationStrings character,
            //calls thread sleep, backspaces, removes character for next character.
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            //Increments index by 1.
            i++;

            //if loop, condition: i is >= animationStrings List count.
            //reset index to 0
            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    //ShowCountDown timer method, parameter: countDownSeconds, no return.
    //Create countDown timer.
    public void ShowCountDown(int countDownSeconds)
    { 
        //For loop, condition: i=countDownSeconds, i>0, decrease i by 1 each loop).
        for (int i = countDownSeconds; i > 0; i--)
        {
            //Display countDownSeconds number, call thread sleep, 1 second.
            Console.Write(i);
            Thread.Sleep(1000);

            //If loop, condition: i<10, 
            //back space, delete character for single digit number.
            //else, double back space, delete characters for 2 digit number.
            if (i < 10)
            {
            Console.Write("\b \b");
            }
            else
            {
              Console.Write("\b\b  \b\b");
            }
        }  
    }
}