using System;

//Create Entry Class.
public class Entry
{
   //create Entry class attributes
   public string _date;
   public string _promptText;
   public string _entryText;

//Create Display function to display and format Entry attributes. Return void
   public void Display()
   {
      Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
      Console.WriteLine($"{_entryText}");
   } 
}