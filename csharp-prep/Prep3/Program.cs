using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
       // string magicString = Console.ReadLine();
       // int magicNumber = int.Parse(magicString);
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);

        int guess = -1;

         while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            string userNumber = Console.ReadLine();
            guess = int.Parse(userNumber);

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