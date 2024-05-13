using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        //_name = name; or "" ?
        //_description = description; or "" ?
        //_duration = duration; or 0 ?

        //initialize member variables
        //might require them to be passed as variables
        //or a constructor to set some/all to default to be changed later
    }

    public void DisplayStartMessage()
    {
       //display the start message
    }

    public void DisplayEndingMessage()
    {
        //display the end message
    }

    public void ShowSpinner(int seconds)
    {
       //pausing while showing a spinner for a certain # of seconds
    }

    public void ShowCountDown(int seconds)
    {
        //pausing while showing a countdown timer for a certain number of seconds
    }
}