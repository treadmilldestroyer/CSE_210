class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventType, string eventTitle, string description, string date, string time, string address, string weather) : base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }


}