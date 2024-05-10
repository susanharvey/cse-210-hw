using System;

class Program
{
    public static void Main(string[] args)
    {

        //Code for when I orignally hardcoded the scripture to memorize.

        //string scriptureText = "For unto us a child is born, unto us a son is given: and the government shall be upon his shoulder: and his name shall be called Wonderful, Counsellor, The mighty God, The everlasting Father, The Prince of Peace.";
        //Scripture scripture = new(new Reference("Isaiah", 9, 6), scriptureText);



        //User welcome, let user pick scripture, get and read user scripture input.

        Console.WriteLine("Welcome to the scripture memorizer program.");
        Console.WriteLine("Choose a scripture you want to memorize.");

        Console.Write("Please type the book name (example Luke): ");
        string book = Console.ReadLine();

        Console.Write("Please type the chapter number (example 5): ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Please type the starting verse number(example 10): ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("Please type the ending verse number. If only 1 verse, type 0 (example 12) or (example 0): ");
        int endVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("Please type the text of your scripture (example Jesus wept.): ");
        string userScripture = Console.ReadLine();


        //Let user decide how many words to hide, get and read user input.
        Console.Write("How many words would you like to be hidden at a time? ");
        int numberToHide = int.Parse(Console.ReadLine());

        //Initialize new reference and new scripture.
        Reference reference = new(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, userScripture);

        //While (true) loop) to clear the console, display the scripture, 
        //give, get, and read user option to press enter or type quit.
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.Write("Press enter to continue or type quit to finish: ");
            string userChoice = Console.ReadLine();

            //If loop to break program if scripture is completely hidden or quit is typed.
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            if (userChoice == "quit")
            {
                break;
            }

            //Call scripture HideRandomWords method, parameter numberToHide, to hide random words. 
            scripture.HideRandomWords(numberToHide);
        }
    }
}

