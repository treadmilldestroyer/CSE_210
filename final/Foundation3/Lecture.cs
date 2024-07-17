public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public override string FullDetails()
    {
        return $"Title: {_eventTitle}\nSpeaker: {_speaker}\nDescription: {_description}\nCapacity: {_capacity}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address}";
    }


}