public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP at: {_rsvpEmail}";
    }

    public string GetReceptionShortDescription()
    {
        return $"Event Type: Reception\nTitle: {GetShortDescription()}";
    }
}