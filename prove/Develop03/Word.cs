using System;

//Create Word class and _textWord, _isHidden, _hiddenText variables.
public class Word
{
    private string _textWord;
    private bool _isHidden;
    private string _hiddenText;

    //Word constructor, parameter string text, initialize _textWord, and _isHidden.
    public Word(string text)
    {
        _textWord = text;
        _isHidden = false;

        //For each loop to replace letters in a word with _ and store in _hiddenText.
        foreach (char letter in _textWord)
        {
            _hiddenText += "_";
        }
    }

    //Hide method, no parameters, no return, to set bool _isHidden to true.
    public void Hide()
    {
        _isHidden = true;
    }

    //Show method, no parameters, no return, to set bool _isHidden to false.
    public void Show()
    {
        _isHidden = false;
    }

    //Bool IsHidden method, no parameters, returns bool _isHidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    //GetDisplayText method, no parameters.
    public string GetDisplayText()
    {

        // if loop, if _isHidden, return _hiddenText or else return _textWord.
        if (_isHidden)
            return _hiddenText;
        else
            return _textWord;

        // could use Ternary operator instead/  return _isHidden ? _hiddenText : _textWord;
    }
}