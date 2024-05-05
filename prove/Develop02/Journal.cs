using System;
using System.IO;
using System.Collections.Generic;

//Create Journal class.
public class Journal
{
   //create and intialize journal entries list.
   public List<Entry>_entries = new List<Entry>();
   // note to me. Above code can be
   // simplified: new() because initializing on the same line. Hence ... under new.
   
   //Create AddEntry Function (parameter:Entry newEntry) to add new journal entries
   // to the entries list. Return void.
   public void AddEntry(Entry newEntry)
   {
      _entries.Add(newEntry);
   }

   //create DisplayAll function which uses a foreach loop to iterate 
   //through all the journal entries in the entries list 
   //and calls entries Display function to format and display it. 
   //Return Void
    public void DisplayAll()
   {
      foreach(Entry e in _entries)
      {
         e.Display();
         Console.WriteLine();
      }         
   }

   //Create SaveToFile Function (Paramter:string FileName) to save the entries list
   // to a txt file. Uses StreamWriter and a foreach loop to iterate through the entries
   // to save each to the txt file. Return Void.
   public void SaveToFile(string fileName)
   {
      using (StreamWriter outputFile = new StreamWriter(fileName))
      {
         foreach(Entry e in _entries)
         {
            outputFile.WriteLine($"{e._date}|{e._affirmation}|{e._promptText}|{e._entryText}");
         }
      }
   }

   //Create LoadFromFile function (Parameter: string FileName) to get the journal entries 
   //from txt file. Clears the entries list so no repetitions when loaded. Uses 
   //File.ReadAllLines to save file entries to a string array and a foreach loop to iterate
   // through the file lines. Creates and intializes new Entry object. Split the entry into
   // parts by dilineator |, and adds them back to the entries list. Return void
   public void LoadFromFile(string fileName)
   {
      _entries.Clear();

      string[] lines = File.ReadAllLines(fileName);

      foreach (string line in lines)
      {
         string[] parts = line.Split("|");

         Entry entry = new();

         entry._date = parts[0];
         entry._affirmation = parts[1];
         entry._promptText = parts[2];
         entry._entryText = parts[3];

         _entries.Add(entry);
      }
   } 
}