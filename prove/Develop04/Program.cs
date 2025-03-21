using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the duration for the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

       
        ShowMenu(duration);
    }

    public static void ShowMenu(int duration)
    {
        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            
            if (choice == "1")
            {
                Breathing breathing = new Breathing(duration, "Breathing");
                breathing.PerformBreathingExercise();
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection(
                    new List<string>
                    {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    },
                    new List<string>
                    {
                        "Why was this experience meaningful to you?",
                        "How did you get started?"
                    },
                    duration, "Reflection");

                reflection.DisplayReflectionPrompts();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing(
                    new List<string>
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    },
                    duration, "Listing");

                listing.DisplayListingPrompt();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye! Thanks for using the Mindfulness Activity Program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}