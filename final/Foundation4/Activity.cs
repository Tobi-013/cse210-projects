public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetLengthMinutes(int lengthMinutes)
    {
        _lengthMinutes = lengthMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();    
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return "...";
    }
}