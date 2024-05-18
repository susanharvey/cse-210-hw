using System;
using System.Collections.Generic;

//Create ListingActivity derived from base Activity class.
public class ListingActivity : Activity 
{
    //Initializes new userList, usedPrompt list, and random. 
    //Declares prompts list. Sets all to private.
    private List<string> _userList = new();
    //Added static to accumulate used prompts across multiple instances.
    private static List<string> _usedPrompts = new(); 
    private Random random = new Random();
    private List<string> _prompts;

    //Listing activity constructor, no parameters.
    //Inherits and initializes name, description, and duration fields.
    //Initializes new promptsList.
    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you to reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 30;

        _prompts = new()
        {
            "---When have you felt the Holy Ghost this week?---",
            "---When have you felt contentment this week?",
            "---When have you felt calm and peaceful this week?---",
            "---What promptings from the spirit did you receive this week?---",
            "---What things brought you joy this week?---",
            "---What were your achievements this week?---",
            "---What beauty did you notice this week>---",
            "---What were the high points of your week?",
            "---What things brought you purpose and fulfilment this week"
        };
    }

    //Listing run method, no parameters, no return.
    //Runs the listing acivity.
    public void Run()
    {
        //Calls the base DisplayStartMessage, no parameter.
        base.DisplayStartMessage();
        Console.WriteLine();

        //Displays user instructions.
        Console.WriteLine("List as many responses as you can to the following prompt.");
        Console.WriteLine();

        //Calls GetRandomPrompt method, no parameters.
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        //Displays begin message with countdown timer.
        Console.Write("You may begin in ");
        base.ShowCountDown(10);
        Console.WriteLine();
        Console.WriteLine();

        //Calls GetListFromUser method, no parameters.
        GetListFromUser();

        //Displays how many things the user listed.
        Console.WriteLine($"You listed {_userList.Count} items!");
        Console.WriteLine();

        //Calls base DisplayEndingMessage, no parameters.
        base.DisplayEndingMessage();
    }

    //GetRandomPrompt method, no parameters, return: randomPrompt.
    //Get random prompt that is not repeated until each prompt is used once.
    public string GetRandomPrompt()
    {
        //Initialize random prompt.
        string randomPrompt;

        //While loop, condition: true.
        //Loop runs until non repeating random prompt is found.
        while (true) 
        {
            //Get a random prompt from prompts list.
            randomPrompt = _prompts[random.Next(_prompts.Count)];

            //If loop, condition: if random prompt not in usedPrompts list.
            if (!_usedPrompts.Contains(randomPrompt)) 
            {
                //Add it to the usedPrompt list.
                _usedPrompts.Add(randomPrompt);

                //If loop, condition: usedPrompts list count = prompts list count.
                if (_usedPrompts.Count == _prompts.Count) 
                {
                    //Clear the usedList to start over after each prompt use once.
                    _usedPrompts.Clear(); 
                }
                //Break the loop when we have a unique prompt.
                break;  
            }
        }
        //Return unique random prompt.
        return randomPrompt;
    }

    //GetListFromUser method, no parameters, return _userList.
    //Get a list of responses from the user.
    public List<string> GetListFromUser()
    {
        //Call DateTime and sets start and end times for activity duration.
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_duration);
 
        //while loop, condition: current time < end time.
        //Display user response carrot, get and read user response.
        //Add repsonse to userList.
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            _userList.Add(userResponse);
        }
        //Return userList.
        return _userList;
    }
}