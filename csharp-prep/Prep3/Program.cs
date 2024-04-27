using System;

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

        // loop for while user is guessing the magic number
        int guess = -1;

         while (magicNumber != guess)
        {
            Console.Write("What is your guess for the magic number? ");
            string userNumber = Console.ReadLine();
            guess = int.Parse(userNumber);

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
        }

    }
}