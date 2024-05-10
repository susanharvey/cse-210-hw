using System;

//Create public Reference class, create private member variables
// _book, _chapter, _verse, and _endverse.
public class Reference
{
   private string _book;
   private int _chapter;
   private int _verse;
   private int _endVerse;

   //Reference Constructor, parameters book, chapter, verse, endVerse, 
   //to intitialize _book, _chapter, _verse, _endVerse,
   public Reference(string book, int chapter, int verse, int endVerse)
   {
      _book = book;
      _chapter = chapter;
      _verse = verse;
      _endVerse = endVerse;
   }

   //2nd constructor not needed with user created scripture
   // because user sets endVerse to an int or 0.

   //Reference Constructor with 3 parameters book, chapter, verse.
   /* public Reference(string book, int chapter, int verse)
     {
        _book = book;
        _chapter = chapter;
        _verse = verse;
     } */

   //member method GetDislayText, no parameters, to create and get reference for scripture.
   //return display text for reference
   public string GetDisplayText()
   {

      //if loop (if endVerse is 0) to determine which reference display 
      //to use.
      if (_endVerse == 0)
      {
         return $"{_book} {_chapter}:{_verse}";
      }
      else
      {
         return $"{_book} {_chapter}:{_verse}-{_endVerse}";
      }

      /* Could use TENARY OPERATOR instead.
      return [CONDITION] ? [TRUE STATEMENT] : [FALSE SATEMENT]
      return _endVerse == 0 ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}: {_verse}-{_endVerse}"; */
   }
}