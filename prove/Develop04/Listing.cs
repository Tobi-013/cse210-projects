public class Listing:MindfulnessActivity
{
    private List<string> _listingprompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes? "

    };
    

    public Listing(List<string> listingprompts, int duration, string name):base(duration,name)
    {
        _listingprompts = listingprompts;
    }

    public List<string> GetListingPrompts()
    {
        return _listingprompts;
    }
    public void SetListingPrompts(List<string> listingprompts)
    {
        _listingprompts = listingprompts;
    }
    public void DisplayListingPrompt()
    {
        StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(3000);
        int timelapse = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timelapse);

        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            
            int index = random.Next(_listingprompts.Count);
            string randomprompt = _listingprompts[index];
            Console.Write("Get ready.");
            

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {randomprompt} ---");
            Console.Write("You may begin in:");
            Countdown(3);
            
            bool tri = true;
            List<string> UserList = new List<string>();
            while (tri)
            {
                Console.Write(">");
                string input = Console.ReadLine();
              
                  if (string.IsNullOrEmpty(input))
                {
                    
                    tri = false;
                }
                else
                {
                    UserList.Add(input);
                }

            }
            Console.WriteLine($"\nYou listed {UserList.Count} items!");
            Console.WriteLine("");
            EndActivity();





        }
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