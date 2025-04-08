using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>();
         Running running1 = new Running("03 Nov 2022",35,7);
         Cycling cycling1 = new Cycling("15 Mar 2023",40,20);
         Swimming swimming1 = new Swimming("28 Jul 2023",15,4);

            activities.Add(running1);
            activities.Add(cycling1);
            activities.Add(swimming1);

       bool quit = false;

        while (quit == false)
        {
            Console.WriteLine();
            Console.WriteLine("Select an activity to view:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. View All");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine(activities[0].GetSummary());
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine(activities[1].GetSummary());
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine(activities[2].GetSummary());
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                foreach (Activity activity in activities)
                {
                    Console.WriteLine(activity.GetSummary());
                }
            }
            else if (choice == "5")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        Console.WriteLine("Thanks for using the exercise tracker!");
    }
}
    