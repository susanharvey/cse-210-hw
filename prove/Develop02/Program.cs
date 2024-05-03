using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        int  optionChoice = -1;
        PromptGenerator _promptText = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your journal program.");

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
            Console.WriteLine(optionChoice);

            if (optionChoice == 1)
            {
                Entry entryText = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                entryText._date = theCurrentTime.ToShortDateString();
                entryText._promptText = _promptText.GetRandomPrompt();
                Console.WriteLine(entryText._promptText);
                Console.Write("> ");
                entryText._entryText = Console.ReadLine();

                journal.AddEntry(entryText);
            }

            else if (optionChoice == 2)
            {
                
                Console.WriteLine("Saving to file....");
                Console.WriteLine("What is the  file name (name.txt)? ");
                string fileName = Console.ReadLine();

               journal.SaveToFile(fileName);
            }
        
            else if (optionChoice == 3)
            {
                Console.WriteLine("File is loading...");

                Console.WriteLine("What is the  file name (name.txt)? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);

                Console.WriteLine("File successfully loaded...");
            } 

            else if (optionChoice == 4)  
            {
                journal.DisplayAll();

            }  

            else if (optionChoice == 5)
            {
                break;
            } 

            else
                Console.WriteLine("Invalid input");

            // Statements that are one line long do not need body brackets.
        }
    }
}