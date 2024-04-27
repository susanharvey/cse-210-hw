using System;

class Program
{
    /* Main Function-calls functions DisplayWelcome,
    PromptUsername, PromptUserNumber, SquareNumber, 
    and DisplayResult. Also creates and stores 
    variables for user name, favorite integer, and 
    fav. integer squared.*/
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName,numberSquared);

    }

    // Function DiplayWelcome-displays welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function PromptUserName-asks for user's name.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Function PropmptUserNumber-asks for users favorite integer.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number(as an integer): ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // Function SquareNumber- suares user's fav. int.
    static int SquareNumber(int userNumber)
    {
         int numberSquared = userNumber * userNumber;
         return numberSquared;
    }

    // Function DisplayResult-displays user name and user's fav. int squared.
    static void DisplayResult( string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
    }
}