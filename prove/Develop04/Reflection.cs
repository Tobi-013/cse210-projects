using System.Security.Cryptography.X509Certificates;

public class Reflection : MindfulnessActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?"
    };
    
    
    
    public Reflection(List<string> prompts,List<string> reflectionQuestions,int duration, string name): base(duration,name)
    {
        _prompts = prompts;
        _reflectionQuestions = reflectionQuestions;
    }

    public List<string> GetReflectionPrompts()
    {
        return _prompts;
    }
    public void SetReflectionPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    
    public void DisplayReflectionPrompts()
    {
        StartActivity();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        Thread.Sleep(3000);
        int timelapse = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timelapse);

        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string randomprompt = _prompts[index];

            Console.WriteLine($"{randomprompt}");
            Console.WriteLine("When you're ready to continue click enter...");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following Questions as the relate to this experience ");
            Console.Write("You may begin in: ");
            Countdown(5);
            string question1 = _reflectionQuestions[0];
            string question2 = _reflectionQuestions[1];
            Console.WriteLine($"\n{question1}");
            Spinner();

            Console.WriteLine($"{question2}");
            Spinner(); 
            Console.WriteLine("WellDone!!");





      
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
      public void Spinner()
      {   
            List<string> spinner =  new List<string>();
            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");
            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);
                int i = 0;
                
            while (DateTime.Now < endTime)
            {   
                string s = spinner[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;
            
             
                if (i >= spinner.Count)
                {
                    i = 0;
                }
            }
      }
      
}