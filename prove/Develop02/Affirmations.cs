using System;

public class Affirmations
{
    //Create and intitialize affirmations list for the user.
    //Source for the affirmations
    // https://www.lifesahmazing.com/31-affirmations-improve-your-self-image/

    public List<string> _affirmations = new List<string>
    {
        "I am enough.",
        "God loves me unconditionally.",
        "I love me. I am unique and have been perfectly fashioned by my heavenly Father.",
        "I believe that I am worthy of love.",
        "I acknowledge my own self-worth; my confidence is soaring.",
        "I am brimming with energy and overflowing with joy.",
        "My body is healthy; my mind is brilliant; my soul is tranquil.",
        "I am superior to negative thoughts and low actions.",
        "I have been given endless talents which I begin to utilize today.",
        "I forgive those who have harmed me in my past and peacefully detach from them.",
        "I possess the qualities needed to be extremely successful.",
        "Creative energy surges through me and leads me to new and brilliant ideas.",
        "Happiness is a choice. I choose happiness today.",
        "My ability to conquer my challenges is limitless; my potential to succeed is infinite.",
        "I can do all things through Christ who strengthens me.",
        "I am bold and courageous. I can stand up for myself.",
        "My thoughts are filled with positivity and my life is full of prosperity.",
        "Today, I abandon my old habits and take up new, more positive ones.",
        "I am loved and appreciated.", 
        "I am blessed with an incredible family and wonderful friends.",
        "Everything that is happening now is happening for my ultimate good.",
        "I radiate beauty, charm, and grace.",
        "Obstacles are moving out of my way; my path is carved towards greatness.",
        "I wake up today with strength in my heart and clarity in my mind.", 
        "My fears of tomorrow are simply melting away.",
        "I am at peace with all that has happened, is happening, and will happen.",
        "I forgive myself for past mistakes and failures.",
        "I am fearfully and wonderfully made.",
        "I have the mind of Christ. My mind is set on things above and not earthly things.",
    };

    //initialize currentIndex
     int currentIndex = 0;

    //Create DisplayNextAffirmation function to display affirmations sequentially.
    public string DisplayNextAffirmation()
    {
        string currentAffirmation = _affirmations[currentIndex];
        
        currentIndex ++;
           
        if (currentIndex >= _affirmations.Count)
        {
            currentIndex = 0;
        }

        Console.WriteLine($"{currentAffirmation}");

        return currentAffirmation;
    }
}