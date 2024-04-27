using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for grade percentage, read it, and parse it to int.
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        
        // If/else statements to determine letter grade.
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
        
        // Display letter grade.
        Console.WriteLine($"Your letter grade is {letter}.");
        
         // If/else statements to determine if passed class.
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