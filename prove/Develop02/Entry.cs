using System;

//Create Entry Class.
public class Entry
{
   //create Entry class attributes
   public string _date;
   public string _affirmation;
   public string _promptText;
   public string _entryText;

//Create Display function to display and format Entry attributes. Return void
   public void Display()
   {
      Console.WriteLine($"Date: {_date} - Affirmation: {_affirmation}");
      Console.WriteLine($"Prompt: {_promptText}");
      Console.WriteLine($"{_entryText}");
   } 
}