using System;

//Public Event Base Class
public class Event
{
    //Declare field variables: _eventType, _title, _description, _date, _time, _address)
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;


    //Event Constructor for full details, Parameters: eventType, title, description, date, time, address
    //Set field variables
    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    //Event Constructor for standard details, Parameters: title, description, date, time, address
    //Set field variables
    public Event(string title, string description, string date, string time, Address address)
    {
          _title = title;
          _description = description;
          _date = date;
          _time = time;
          _address = address;
    }


    //Event Constructor for short description, Parameters: eventType, title, date
    //Set field variables
    public Event(string eventType, string title, string date)
    {
         _eventType = eventType;
          _title = title;
          _date = date;
    }


    //GetEventAddress method, Parameters: none
    //Return address
     public Address GetEventAddress()
    {
        return _address;
    }


    //GetEventName method, Parameters: none
    //Return event title
    public string GetEventName()
    {
        return _title;
    }


    //GetStandardDetails method, Parameters: none
    //Return standard details of Event title, description, date, time, and address
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }


    //GetShortDescription method, Parameters: none
    //Return short description of event type, title, and date
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
}