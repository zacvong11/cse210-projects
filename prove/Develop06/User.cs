using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class User
    {
        public int Score { get; private set; }
        private List<Goal> Goals { get; set; }

        public User()
        {
            Goals = new List<Goal>();
            Score = 0;
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1 - Simple Goal");
            Console.WriteLine("2 - Eternal Goal");
            Console.WriteLine("3 - Checklist Goal");
            string type = Console.ReadLine();

            Console.Write("Goal name: ");
            string name = Console.ReadLine();

            Console.Write("Goal description: ");
            string description = Console.ReadLine();

            Console.Write("Points associated with the goal: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "1":
                    Goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    Goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished? ");
                    int requiredCompletions = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points upon completion: ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    Goals.Add(new ChecklistGoal(name, description, points, requiredCompletions, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        public void ListGoals()
        {
            Console.WriteLine("\nGoals:");
            foreach (var goal in Goals)
            {
                Console.WriteLine(goal.DisplayStatus());
            }
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Total Points: {Score}");
                foreach (var goal in Goals)
                {
                    writer.WriteLine(goal.SaveFormat());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    Goals.Clear();
    Score = 0;

    using (StreamReader reader = new StreamReader(filename))
    {
        string line = reader.ReadLine();
        if (line != null && line.StartsWith("Total Points:"))
        {
            Score = int.Parse(line.Split(": ")[1]);
        }

        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            if (parts.Length < 5)
            {
                Console.WriteLine("Error: Invalid file format.");
                continue;
            }

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);

            Goal goal = null;

            switch (goalType)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(name, description, points) { IsComplete = isComplete };
                    break;

                case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;

                case "ChecklistGoal":
                    if (parts.Length < 9)
                    {
                        Console.WriteLine("Error: Invalid file format for ChecklistGoal.");
                        continue;
                    }

                    int requiredCompletions = int.Parse(parts[5]);
                    int currentCompletions = int.Parse(parts[6]);
                    int bonusPoints = int.Parse(parts[7]);

                    goal = new ChecklistGoal(name, description, points, requiredCompletions, bonusPoints)
                    {
                        IsComplete = isComplete,
                        CurrentCompletions = currentCompletions
                    };
                    break;

                default:
                    Console.WriteLine($"Error: Unknown goal type '{goalType}'.");
                    continue;
            }

            if (goal != null)
            {
                Goals.Add(goal);
            }
        }
    }
    Console.WriteLine("Goals loaded successfully!");
}

        public void RecordEvent()
        {
            ListGoals();
            Console.Write("Select a goal to record progress (enter the number): ");
            // here I made it so the user doesn't have to type the goal they want to record progress on, they select the goal by putting in 1, 2, 3, etc for the first or second goal
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < Goals.Count)
            {
                Score += Goals[index].RecordProgress();
                Console.WriteLine("Progress recorded.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }
    }
}
