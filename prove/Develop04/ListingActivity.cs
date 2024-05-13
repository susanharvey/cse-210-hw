using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new();

    public ListingActivity()
    {
        // _name = "Listing";
        // _description = "This activity will help you list   ...";
        // _duration = 50;

        //needs to initilaize variables and prompts
    }

    public void Run()
    {
        //run the activity
    }

    public void getRandomPrompt()
    {
        //get a random prompt
    }

    public List<string> GetListFromUser()
    {
        //get a list of responses from the user
        return _prompts;
    }
}