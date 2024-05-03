using System;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;

public class Journal
{
   public List<Entry>_entries = new List<Entry>();
   // Above line can be simplified: new();
   
   public void AddEntry(Entry newEntry)
   {
      _entries.Add(newEntry);
   }

    public void DisplayAll()
   {
      foreach(Entry e in _entries)
      {
         e.Display();
         Console.WriteLine();
      }        
   }

   public void SaveToFile(string fileName)
   {
      using (StreamWriter outputFile = new StreamWriter(fileName))
      {
         foreach(Entry e in _entries)
         {
            outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
         }
      }
   }
     
   public void LoadFromFile(string fileName)
   {
      _entries.Clear();
      string[] lines = File.ReadAllLines(fileName);

      foreach (string line in lines)
      {
         string[] parts = line.Split("|");
         Entry entry = new();
         entry._date = parts[0];
         entry._promptText = parts[1];
         entry._entryText = parts[2];
         _entries.Add(entry);
      }
   } 
}