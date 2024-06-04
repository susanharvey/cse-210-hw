using System;

//Public Receptions class derived from Event class.
public class Receptions : Event
{
    //Declare field variables: _email)
    private string _email;


    //Receptions constructor for full details, Parameters: eventType, title, description, date, time, address, and email
    //Inherits and initializes eventType,  title, description, date, time, and address fields
    //Inititialzes email field
    public Receptions(string eventType, string title, string description, string date, string time, Address address, string email) : base(eventType, title, description, date, time, address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _email = email;
    }


    //GetFullDetails method, Parameters: none
    //Return full details of event type,  title, description, date, time, address, and rsvp email
    //Get address by calling GetEventAddress.GetAddressString methods
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{GetEventAddress().GetAddressString()}\nRSVP email: {_email}";
    }
}