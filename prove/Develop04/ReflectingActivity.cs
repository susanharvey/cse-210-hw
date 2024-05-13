using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new();
    private List<string> _questions = new();

    public ReflectingActivity()
    {
       // _name = "Reflecting";
       // _description = "This activity will help you reflect on times ...";
       // _duration = 50;

        // Set other values here that are unique to the Reflecting Activity
    
        //needs to initialize variables and list of prompts and questions
        //and populate them with values

    }

    public void Run()
    {
        //run the activity
    }

    public string GetRandomPrompt()
    {
        //get a random prompt
        return "randomPrompt";
    }

    public string GetRandomQuestion()
    {
        //get a random question
        return "randomQuestion";
    }

    public void DisplayPrompt()
    {
        //display the prompt
    }

    public void DisplayQuestions()
    {
        //display the questions about the prompt
        //and get answers
    }
}   