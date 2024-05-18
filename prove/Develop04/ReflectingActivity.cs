using System;
using System.Collections.Generic;

//Create ListingActivity derived from base Activity class.
public class ReflectingActivity : Activity
{
    //Declares prompts list, questions list, and randomPrompt. 
    //Initializes usedPrompts list, usedQuestions list and random.
    //Sets all to private.
    private List<string> _prompts;
    private List<string> _questions;
     private string _randomPrompt;

    //Added static to accumulate used prompts and questions across multiple instances.
    private static List<string> _usedPrompts = new(); 
    private static List<string> _usedQuestions = new(); 
    Random random = new();

    //Reflecting activity constructor, no parameters.
    //Inherits and initializes name, description, and duration fields.
    //Initializes new promptsList and questions list.
    public ReflectingActivity() 
    {
       _name = "Reflecting";
       _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.\n\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
       _duration = 30;

        _prompts = new  List<string>()
        {
            "---Think of a time when you did something really difficult.---",
            "---Think of a time when you stood up for yourself or for someone you love.---",
            "---Think of a time when you failed but you kept tryng until you were successful.---",
            "---Think of a time when you faced adversity with courage.---",
            "---Think of a time when you received grace to do something you couldn't have done on your own.---",
            "---Think of a time when you didn't think you could do something, but you did it.---"
        };

        _questions = new List<string>()
        {
            ">How did you feel when it was over?",
            ">What was the best thing about this experience?",
            ">What was the most important thing you learned about yourself from this experience?",
            ">How did this experience help you to grow?",
            ">What strengths did you have that helped you during this experience?",
            ">What advise would you give yourself if you could go back and coach yourself through this experience?"
        };
    }

    //Reflecting Activity run method, no parameters, no return.
    //Runs reflecting activity.
    public void Run()
    {
        //Call base DisplayStartMessage method, no parameters.
        base.DisplayStartMessage();

        //Call DateTime, set start time and end time for duration chosen by user.
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_duration);

        //While loop, condition: current time < end time.
        while (DateTime.Now < endTime)
        {
            //Call GetRandomPrompt method, no parameter, 
            //and set it to _randomPrompt.
            _randomPrompt = GetRandomPrompt();

            //Call DisplayPrompt method, parameter: _randomPrompt.
            DisplayPrompt(_randomPrompt);

            //Display and read user instructions and response.
            Console.Write("When you have something in mind, press enter to continue. ");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to ths experience.\n");

            //Display begin message with spinner, clear console.
            Console.Write($"You may begin in ");
            base.ShowCountDown(8);

            Console.Clear();

            //Call GetRandomQuestion method, no parameter, set to randomQuestion1.
            //Call DisplayQuestions method, Parameter: randomQuestion1.
            Console.WriteLine();
            string randomQuestion1 = GetRandomQuestion(); 
            DisplayQuestions(randomQuestion1);

            //Call GetRandomQuestion method, no parameter, set to randomQuestion2.
            //Call DisplayQuestions method, Parameter: randomQuestion2.
            string randomQuestion2 = GetRandomQuestion();
            DisplayQuestions(randomQuestion2);
        }

        //Call base DisplayEndingMessage, no parameters.
        Console.WriteLine();
        base.DisplayEndingMessage();
    }

    //GetRandomPrompt method, no parameters, return: randomPrompt.
    //Get randomPrompt that is not repeated until each prompt is used once.
    public string GetRandomPrompt()
    {
        //Initialize randomPrompt.
        string randomPrompt;

        //While loop, condition: true.
        //Loop runs until non repeating random prompt is found.
        while (true) 
        {
            //Get a random prompt from prompts list.
            randomPrompt = _prompts[random.Next(_prompts.Count)];

            //If loop, condition: if randomPrompt not in usedPrompts list.
            if (!_usedPrompts.Contains(randomPrompt)) 
            {
                //Add it to the usedPrompt list.
                _usedPrompts.Add(randomPrompt);

                //If loop, condition: usedPrompts list count = prompts list count.
                if (_usedPrompts.Count == _prompts.Count) 
                {
                    //Clear the usedList to start over after each prompt is used once.
                    _usedPrompts.Clear(); 
                }
                //Break the loop when we have a unique prompt.
                break;  
            }
        }
        //Return unique random prompt.
        return randomPrompt;
    }

    //GetRandomQuestion method, no parameters, return: randomQuestion.
    //Get random question that is not repeated until each is used once.
    public string GetRandomQuestion()
    {
        //Initialize randomQuestion.
        string randomQuestion;

        //While loop, condition: true.
        //Loop runs until non repeating random question is found.
        while (true) 
        {
            //Get a random question from questions list.
            randomQuestion = _questions[random.Next(_questions.Count)];

            //If loop, condition: if randomQuestion not in usedQuestions list.
            if (!_usedQuestions.Contains(randomQuestion)) 
            {
                //Add it to the usedQuestion list.
                _usedQuestions.Add(randomQuestion);

                //If loop, condition: used questions list count = questions list count.
                if (_usedQuestions.Count == _questions.Count) 
                {
                    //Clear the usedList to start over after each question used once.
                    _usedQuestions.Clear(); 
                }
                //Break the loop when we have a unique question.
                break;  
            }
        }
        return randomQuestion;
    }

     //DisplayPrompt method, parameter: randomPrompt, no return.
     //Display the randomPrompt.
    public void DisplayPrompt(string randomPrompt)
    {
        Console.WriteLine($"Consider the following prompt:\n{randomPrompt}\n");
    }

     //DisplayQuestions method, parameter randomQuestion, no return.
     //Display the random question about the prompt and spinner.
    public void DisplayQuestions(string randomQuestion)
    {
        Console.Write(randomQuestion); 
        base.ShowSpinner(_duration / 2);
        Console.WriteLine();
    }
}   