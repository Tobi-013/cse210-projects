using System;

class Program
{
    static void Main(string[] args)
    {
         GoalManager goalManager = new GoalManager();
        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(goalManager);
            }
            else if (choice == "2")
            {
                goalManager.DisplayGoals();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                goalManager.SaveGoals(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                goalManager.LoadGoals(filename);
            }
            else if (choice == "5")
            {
                goalManager.DisplayGoals();
                Console.Write("Which goal did you complete? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                goalManager.RecordEvent(index);
            }
            else if (choice == "6")
            {
                goalManager.DisplayScore();
            }
            else if (choice == "7")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }

        Console.WriteLine("Goodbye, brave goal slayer! 🗡️");
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            goalManager.AddGoal(simple);
        }
        else if (type == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            goalManager.AddGoal(eternal);
        }
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            goalManager.AddGoal(checklist);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    
    }
}