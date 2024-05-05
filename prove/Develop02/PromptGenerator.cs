using System;

//Create PromptGenerator Class.
public class PromptGenerator
{
    //Create and initialize a journal promptlist with journal prompts for the user.
    public List<string> _prompts = new List<string>
    {
        "What tender mercies from the Lord did I see in my day today?",
        "What acts of kindness did I do today?",
        "What was my most meaningful interaction with someone else today?",
        "What inspiration did I receive today as I studied my scriptures?",
        "What was the funniest thing in my day today?",
        "What was my favorite part of today?"
    };

    //Call and initialize Random, creat GetRandomPrompt Function, Return random prompt.
    public Random random = new Random();
    public string GetRandomPrompt()
    {
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        return randomPrompt;
    }
}

