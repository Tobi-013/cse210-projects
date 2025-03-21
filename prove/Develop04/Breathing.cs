public class Breathing : MindfulnessActivity
{
    public Breathing (int duration, string name):base (duration,name)
    {
               
    }
    
    public void PerformBreathingExercise()
    {
        StartActivity();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int timelapse = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timelapse);

        while (DateTime.Now < endTime)
        {
            Console.Write("\rBreathe in");
            Countdown(4);
            
            Console.Write("\rBreathe Out");
            Countdown(4);
            
        }
        EndActivity(); 
    }

      public void Countdown(int seconds)
      {  
        for (int i = seconds; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b  \b");

        }
            
      }
    }
    
    
