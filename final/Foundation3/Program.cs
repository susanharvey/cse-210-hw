using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize new lecture event, nest new event Address,  Parameters: eventType, title, description, date, time, address, speaker, capacity
        //Display lecture full details, standard details, and short description
        //by calling GetFullDetails, GetStandardDetails, and GetShortDescription methods

        Lectures lecture = new(
            "lecture",
            "Mastering Object Oriented Programming",
            "Learn to hone your object oriented programming skills.",
            "September 15th, 2024",
            "7 pm",
            new Address(
                "5542 Constitution Avenue", "Phoenix", "Arizona", "USA"
            ),
            "Br. Burton",
            125
            );
        Console.WriteLine();
        Console.WriteLine($"Lecture: {lecture.GetEventName()} Full Details\n\n{lecture.GetFullDetails()}");
        Console.WriteLine();

        Console.WriteLine($"Lecture: {lecture.GetEventName()} Standard Details\n\n{lecture.GetStandardDetails()}");
        Console.WriteLine();

        Console.WriteLine($"Lecture: {lecture.GetEventName()} Short Description\n\n{lecture.GetShortDescription()}");
        Console.WriteLine();
        Console.WriteLine();


        //Initialize new receptions event, nest new event Address,  Parameters: eventType, title, description, date, time, address, email
        //Display reception full details, standard details, and short description
        //by calling GetFullDetails, GetStandardDetails, and GetShortDescription methods

        Receptions reception = new(
            "reception",
            "Jones/Mack Wedding Reception",
            "Jones/Mack formal wedding reception with dinner and dancing",
            "August 1st, 2024",
            "6:00 pm",
            new Address(
                "912 6th Street NW", "Albuquerque", "New Mexico", "USA"
            ),
            "We are excited to invite you to our wedding reception on August 1. The reception will begin at 6:00 pm. Please let us know if you'll be able to share in our joy by responding to this email with your RSVP by May 31. We hope to see you there!"
            );

        Console.WriteLine($"Reception: {reception.GetEventName()} Full Details\n\n{reception.GetFullDetails()}");
        Console.WriteLine();

        Console.WriteLine($"Reception: {reception.GetEventName()} Standard Details\n\n{reception.GetStandardDetails()}");
        Console.WriteLine();

        Console.WriteLine($"Reception: {reception.GetEventName()} Short Description\n\n{reception.GetShortDescription()}");
        Console.WriteLine();
        Console.WriteLine();


        //Initialize new receptions event, nest new event Address,  Parameters: eventType, title, description, date, time, address, email
        //Display reception full details, standard details, and short description
        //by calling GetFullDetails, GetStandardDetails, and GetShortDescription methods

        OutdoorGatherings outdoorGathering = new(
            "outdoor gatherings",
            "Lacasa Fundraiser",
            "Lacasa shelter for women fundraiser auction",
            "June 15, 2024",
            "4:00 pm",
            new Address(
                "7060 Jane St", "Concord", "Ontario", "Canada"
            ),
            "Mainly cloudy with 5 percent chance of showers."
            );

        Console.WriteLine($"OutdoorGathering: {outdoorGathering.GetEventName()} Full Details\n/n{outdoorGathering.GetFullDetails()}");
        Console.WriteLine();

        Console.WriteLine($"OutdoorGathering: {outdoorGathering.GetEventName()} Standard Details\n\n{outdoorGathering.GetStandardDetails()}");
        Console.WriteLine();

        Console.WriteLine($"OutdoorGathering: {outdoorGathering.GetEventName()} Short Description\n\n{outdoorGathering.GetShortDescription()}");
    }
}