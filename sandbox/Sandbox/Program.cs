using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome to Sandbox World!");
       List<string> prompts = new List<string>
       {
        "yourday", "your dog", "your spouse", "your food"
       };

       Random random = new Random();
       
       //string randomPrompt = prompts[random.Next(prompts.Count)];

       // OR
       // // Generate a random index within the range of the list
       // int randomIndex = random.Next(0, sentenceList.Count);
        // Access the sentence at the random index
        //string randomSentence = sentenceList[randomIndex];

       //Console.WriteLine($"{randomPrompt}");

    }
}