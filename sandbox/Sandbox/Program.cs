using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);

        // do while loop for user guessing the magic number.
        int guess = -1;

        do
        {
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