using System;
using System.Collections.Generic;

//Public Comment Class
public class Comment
{
    //Declare field variables: _commentAuthor and _commentText
    public string _commentAuthor;
    public string _commentText;


    //Comment Constructor, Parameters: commentAuthor and commentText
    //Initialize field variables
    public Comment(string commentAuthor, string commentText )
    {
        _commentAuthor = commentAuthor;
        _commentText = commentText;
    }
}