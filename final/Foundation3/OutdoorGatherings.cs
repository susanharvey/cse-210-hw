using System;

//Public OutdoorGatherings class derived from Event class.
public class OutdoorGatherings : Event
{
    //Declare field variables: _weather)
    private string _weather;


    //OutdoorGatherings constructor for full details, Parameters: eventType, title, description, date, time, address, and weather
    //Inherits and initializes eventType,  title, description, date, time, and address fields
    //Inititialzes weather field
    public OutdoorGatherings(string eventType, string title, string description, string date, string time, Address address, string weather) : base(eventType, title, description, date, time, address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }


    //GetFullDetails method, Parameters: none
    //Return full details of event type,  title, description, date, time, address, and weather report
    //Get address by calling GetEventAddress.GetAddressString methods
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{GetEventAddress().GetAddressString()}\nWeather Report: {_weather}";
    }
}