using System;

//Public Lectures class derived from Event class.
public class Lectures : Event
{
    //Declare field variables: _speaker, _capacity)
    private string _speaker;
    private int _capacity;


    //Lectures constructor for full details, Parameters: eventType, title, description, date, time, address, speaker, and capacity
    //Inherits and initializes eventType title, description, date, time and address, speaker, and capacity fields
    //Inititialzes speaker and capacity fields
    public Lectures(string eventType, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(eventType, title, description, date, time, address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }


    //GetFullDetails method, Parameters: none
    //Return full details of event type,  title, description, date, time, address, speaker and capacity
    //Get address by calling GetEventAddress.GetAddressString methods
    public string GetFullDetails()
    {
        return $"Event type: {_eventType}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{GetEventAddress().GetAddressString()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}