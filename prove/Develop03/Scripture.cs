using System;
using System.Collections.Generic;

//Create public Scripture class, create private member
// variables _reference, List _words,
// and initialize List -words, intialize random. 
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Random random = new Random();

    //Constructor Scripture, parameters reference and text.
    public Scripture(Reference reference, string text)
    {
        //initilaize _reference
        _reference = reference;

        //create string array and split text at "".
        string[] words = text.Split(" ");

        //For each loop, loop through split array words, 
        //add each word as an object to _words list.
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }


    //Create method HideRandomWords, parameter NumberToHide, 
    //to hide random words, no return.
    public void HideRandomWords(int numberToHide)
    {
        //For loop, set i to 0, 
        //as long as i is less than numberToHide,
        //increment i by 1 in each loop
        for (int i = 0; i < numberToHide; i++)
        {
            //Create index variable
            int index;

            //Do while loop, use random.next to get random index 
            //while the word at the random index is already hidden.
            do
            {
                index = random.Next(_words.Count);
            } while (_words[index].IsHidden());

            //Hide the word at the random index.
            _words[index].Hide();

            //if loop, if all the words are completely hidden, 
            //break the for loop.
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    //Create member method GetDisplayText, no parameters, 
    //to get display text for scripture with hidden words, 
    //return text.
    public string GetDisplayText()
    {
        //Add scripture reference to the display.
        string text = $"{_reference.GetDisplayText()} ";

        //For each loop to add the scripture text 
        //with hidden words to the display.
        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }
        return text;
    }

    //Create bool method IsCompletelyHidden, no parameters,
    public bool IsCompletelyHidden()
    {

        //For each loop, for each word in the _words list, 
        foreach (Word word in _words)
        {

            //if any word is not hidden return false, 
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // //if all the words are hidden, return true.
        return true;
    }
}