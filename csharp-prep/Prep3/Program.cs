using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Code for user picking magic number.

        // Console.Write("What is the magic number? ");
       // string magicString = Console.ReadLine();
       // int magicNumber = int.Parse(magicString);
        
        // Call random generator and have it pick magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        
        int guess = -1;
         // Do while loop for user guessing the magic number.
        do
        { 
            // Let user guess magic number and change string response to int.
            Console.Write("What is your guess for the magic number? ");
            guess = int.Parse(Console.ReadLine());

            // if/else statements for higher/lower/you guessed it displays.
            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                 Console.WriteLine("You guessed it!");
            } 
        } while (magicNumber != guess);

    }
}