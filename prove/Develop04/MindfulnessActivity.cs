using Microsoft.VisualBasic;

public class MindfulnessActivity
{
    private int _duration;
    private string _name;

    public MindfulnessActivity(int duration, string name)
    {
        _duration = duration;
        _name = name;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name; 
    }
    

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); 
    }
    public void EndActivity()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"You have finished the {_name} activity for {_duration} seconds.");
    }
}