using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //intialize OptionChoice, _promptText, journal, and affirmation 
        int optionChoice = -1;
        PromptGenerator _promptText = new PromptGenerator();
        Journal journal = new Journal();
        Affirmations affirmation = new Affirmations();

        Console.WriteLine("Welcome to your journal program.");

        //Begin While loop for choice options. List choice options 
        // for user and parse the option string to an int.
        while (optionChoice != 5)
        {   
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1 Write a journal entry");
            Console.WriteLine("2 Save journal entry");
            Console.WriteLine("3 Load your journal entries");
            Console.WriteLine("4 Display all journal entries");
            Console.WriteLine("5 Quit");
            Console.Write("What would you like to do? ");

            optionChoice = int.Parse(Console.ReadLine());

            // Begin if and if else statements to handle each options choice.

            // get current date, current affirmation, random prompt, and user journal entry,
            //call journal AddEntry function
            if (optionChoice == 1) 
            {
                Entry entryText = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                entryText._date = theCurrentTime.ToShortDateString();

                entryText._affirmation = affirmation.DisplayNextAffirmation();

                entryText._promptText = _promptText.GetRandomPrompt();
                Console.WriteLine(entryText._promptText);
                Console.Write("> ");
                entryText._entryText = Console.ReadLine();

                journal.AddEntry(entryText);
            }

            //Get journal txt file name from user, call journal SaveToFile Function
            else if (optionChoice == 2)
            {
                Console.WriteLine("What is the  file name (name.txt)? ");
                string fileName = Console.ReadLine();

               journal.SaveToFile(fileName);
            }
        
            //Get journal txt file name from user, call journal LoadFromFile Function
            else if (optionChoice == 3)
            {
                Console.WriteLine("What is the  file name (name.txt)? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            } 
 
            //Call the journal DisplayAllfunction
            else if (optionChoice == 4)  
            {
                journal.DisplayAll();
            }  

            //Quit the Program if choice 5 is selected
            else if (optionChoice == 5)
            {
                break;
            } 

            //display inavid input if user types in an error and lets them reselect.
            else
                Console.WriteLine("Invalid input");
        // note to me, statements that are one line long do not need body brackets.
        }
    }
}