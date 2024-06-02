using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Initialize new _videos list
        List<Video> _videos = new();
 

        //Initialize and set new video1, Parameters: video title, author, length
        //Add video1 to _videos list
        Video video1 = new("A Journey of Faith", "Jane Smith", 300);
        _videos.Add(video1);
 
       
        //Initialize new commentText and add to video1 comment list
        //Parameters: comment author and comment text
        video1._comments.Add(new Comment("Fred Jones", "This video is very inspiring!"));
        video1._comments.Add(new Comment("Mary Fowler", "Great perspective! I loved it!"));
        video1._comments.Add(new Comment("Sally DeVroe", "It was just okay."));


        //Initialize and set new video2, Parameters: video title, author, length
        //Add video2 to _videos list
        Video video2 = new("Moving Forward In Spite of Fear", "Gabriel Connor", 420);
        _videos.Add(video2);


        //Initialize new commentText and add to video2 comment list
        //Parameters: comment author and comment text
        video2._comments.Add(new Comment("Sarah Metts", "This helped me get out of my rut."));
        video2._comments.Add(new Comment("Cory Schmidt", "Slow start, but then very interesting."));
        video2._comments.Add(new Comment("Ben Dorr", "Helped me have the courage to move forward."));
 
       
 
        //Initialize and set new video3, Parameters: video title, author, length
        //Add video3 to _videos list
        Video video3 = new("Finding Hope After Loss", "Brooklyn Neill", 360);
        _videos.Add(video3);

 
        //Initialize new commentText and add to video3 comment list
        //Parameters: comment author and comment text
        video3._comments.Add(new Comment("Robert Beck", "It's hard to pick up the pieces and move on."));
        video3._comments.Add(new Comment("Jane Mitz", "It's helpful to know others struggle, too."));
        video3._comments.Add(new Comment("John Hubert", "I look forward to healing."));
 
       
 
        //Foreach loop, condition: for video in list _videos
        //For each video, call DisplayVideoInfo and DisplayVideoComments
        //Display Video and Comment info
        foreach(Video video in _videos)
        {
            video.DisplayVideoInfo();
            video.DisplayVideoComments();
            Console.WriteLine();
        }
    }
}