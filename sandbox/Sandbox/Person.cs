using System.Security.Cryptography.X509Certificates;

public class Resume
{
   public string _name;
   public List<Job> _jobs; 

   public void Display()
   {
    Console.WriteLine($"{_name} - {_jobs}");
   }
}

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