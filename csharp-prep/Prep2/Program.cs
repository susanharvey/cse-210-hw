using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade pecentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter;

        if (number >= 90 && number <= 100)
        {
            letter = "A";
        }

        else if (number >= 80 && number <= 89)
        {
             letter = "B";
        }

         else if (number >= 70 && number <= 79)
        {
             letter = "C";
        } 

         else if (number >= 60 && number <= 69)
        {
             letter = "D";
        }

         else
        {
             letter = "F";
        }  

        Console.WriteLine($"Your letter grade is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed this class.");
        }
        else
        {
           Console.WriteLine("You did not pass this class. Work hard and pass it next time!"); 
        }
    }   
}