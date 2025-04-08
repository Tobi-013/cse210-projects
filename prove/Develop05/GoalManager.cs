using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
         Console.WriteLine("Your Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            string goalStatus = _goals[i].GetStatus();
            Console.WriteLine((i + 1) + ". " + goalStatus);
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine("Your current score is: " + _score);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];

            goal.RecordEvent();

            _score = _score + goal.GetPoints();

            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklist = (ChecklistGoal)goal;

                if (checklist.IsComplete() && checklist.GetCurrentCount() == checklist.GetTargetCount())
                {
                    _score = _score + checklist.GetBonusPoints();
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

        public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score.ToString());

            for (int i = 0; i < _goals.Count; i++)
            {
                string goalLine = _goals[i].GetStringRepresentation();
                writer.WriteLine(goalLine);
            }
        }

        Console.WriteLine("Goals successfully saved to " + filename);
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _goals.Clear();

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] details = parts[1].Split(',');

                if (goalType == "SimpleGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    bool isComplete = bool.Parse(details[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.GetStatus(); 
                    }
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    int target = int.Parse(details[3]);
                    int current = int.Parse(details[4]);
                    int bonus = int.Parse(details[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    goal.SetCurrentCount(current);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals successfully loaded from " + filename);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    

}