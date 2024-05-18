using System;
using System.Threading;

//For creativity/exceeds core requirements.... 
//I added code so that my Reflecting and Listing GetRandom Prompts and Questions methods
//find and return a random, non repeating prompt/question until each item in the
//list has been used once.
class Program
{
    static void Main(string[] args)
    {
        //While loop, condition true, loops until user types 4 for quit.
        while (true)
        {
            //Clear the console each time the menu is displayed.
            Console.Clear();

            //Display menu options for the user. 
            //1. Breathing activity, 2. Reflecting Activity,
            //3. Listing Activity, 4. Quit.
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");

            //Get user menu option input and parse the string.
            Console.Write("Select a choice from the menu: ");
            int userResponse = int.Parse(Console.ReadLine());

            //Clear the console again.
            Console.Clear(); 

            //Switch statement for menu options.
            //Each case initilaizes new instance 
            //and calls the appropriate activity's run method.
            switch (userResponse)
            {
                case 1:
                    BreathingActivity breathingActivity = new();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new();
                    listingActivity.Run();
                    break;
                case 4: // Quit program and quit meesage.
                    Console.WriteLine("Come back again, soon!");
                    return;
                default: //default if invalid number is typed and goes back to menu.
                    Console.WriteLine("Please type 1, 2, 3, or 4.\nPress enter to return to the menu. ");
                    Console.ReadLine();
                break;
            }
        } 
    }
}