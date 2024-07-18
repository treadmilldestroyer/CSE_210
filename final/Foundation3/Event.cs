using System.Diagnostics;

public abstract class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address; 
    }

    public string StandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address}";
    }
    
    public abstract string FullDetails();

    public string ShortDescription()
    {
        return $"Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}