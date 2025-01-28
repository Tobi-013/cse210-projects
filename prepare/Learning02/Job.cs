public class Job
{
    public string _companyname;
    public string _jobtitle;
    public int _startyear;
    public int _endyear;

    public void Display()
    {
        Console.WriteLine($"{_jobtitle} ({_companyname}) {_startyear}-{_endyear}");
    }
}