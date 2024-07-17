public class Reception : Event
{
    private string _emailAddress;

    public Reception(string eventType, string eventTitle, string description, string date, string time, Address address, string emailAddress) : base(eventType, eventTitle, description, date, time, address)
    {
        _emailAddress = emailAddress;
    }

    public string GetEmailAddress()
    {
        return _emailAddress;
    }
    public override string FullDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address}\nRSVP: {_emailAddress}";
    }

}