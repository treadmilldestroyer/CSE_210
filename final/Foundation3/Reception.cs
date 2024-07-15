class Reception : Event
{
    private string _emailAddress;

    public Reception(string eventType, string eventTitle, string description, string date, string time, string address, string emailAddress) : base(eventType, eventTitle, description, date, time, address)
    {
        _emailAddress = emailAddress;
    }

    public string GetEmailAddress()
    {
        return _emailAddress;
    }

}