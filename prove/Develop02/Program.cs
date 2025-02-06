using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit");
    }

    static void Main(string[] args)
    {
      Journal myjournal = new Journal();
      bool continuerun = true;
      while(continuerun)
      { 
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine(); 
        if(choice == "1")
        {   
            List<string> prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
            Random random = new Random();
            string randomPrompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"{randomPrompt}");
            string response =  Console.ReadLine();

            // Create the entry object and add it to the list inside the journal
            Entry newentry1 = new Entry();
            newentry1._prompt = randomPrompt;
            newentry1._response = response;
            DateTime theCurrentTime = DateTime.Now;
            newentry1._date = theCurrentTime.ToShortDateString();
            
            myjournal._entries.Add(newentry1);
        }
        else if (choice == "2")
        {
            myjournal.DisplayJournal();
        }
        else if (choice == "3")
        {

        }
        else if (choice == "4")
        {
            Console.Write("What is the filename you would like to use?");
            string filename = Console.ReadLine();
        }
        else if (choice == "5")
        {
            continuerun = false;
        }
      }
    }
}