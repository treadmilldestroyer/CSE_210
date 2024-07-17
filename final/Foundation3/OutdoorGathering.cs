public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventType, string eventTitle, string description, string date, string time, Address address, string weather) : base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public override string FullDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address}\nWeather: {_weather}";
    }

}