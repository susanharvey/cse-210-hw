using System;
using System.Collections.Generic;

//Public Video Class
public class Video
{
    //Declare field variables: _title, _author, _length, and _comments list
    //Initialize _comments list
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments = new();


    //Video Constructor, Parameters: title, author, length
    //Initialize field variables
    public Video(string title, string author, int lengthInSeconds )
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }


    //NumberOfComments method, Parameters: none
    //Return: number of comments
    //Uses  _comments.Count to get length of list
    public int NumberOfComments()
    {
        int numberOfComments = _comments.Count();
        return numberOfComments;
    }


    //DisplayVideoInfo method, Parameters: none, Return: void
    public void DisplayVideoInfo() 
    {
        //Display video title, author, length, and number of comments
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length(secs): {_lengthInSeconds}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
    }


    //DisplayVideoComments method, Parameters: none, Return: void
    public void DisplayVideoComments ()
    {
        //Initialize counter i variable to 1
        int i = 1;

        //Foreach loop, condition: for comment in list _comments
        foreach (Comment comment in _comments)
        {
            //Display comment author and comment text, increase counter i by 1 each loop
            Console.WriteLine($"{i}. {comment._commentAuthor} - {comment._commentText}");
            i++;
        }
    } 
}