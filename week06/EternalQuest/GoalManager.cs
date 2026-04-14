using System;
using System.Collections.Generic;
using System.IO;
using EternalQuest;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }
    public void Start()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void ListGoalNames()
    {
        
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Your goals: ");

            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }

            Console.WriteLine();
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the Type of goal:");
        Console.WriteLine();

        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();

        Console.Write("Which goal do you want to create? ");
        int goalChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (goalChoice > 3)
        {
            Console.WriteLine("Enter a Valid Choice: ");
            goalChoice = int.Parse(Console.ReadLine());
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (goalChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (goalChoice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available");
            return;
        }

        Console.WriteLine("Select a goal:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[choice].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("What's the file name for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Your score: {_score}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name}: {goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What's the filename for the goal file?: ");
        string fileName = Console.ReadLine();

        while (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length == 0)
        {
            Console.WriteLine("Save file is empty.");
            return;
        }

        _goals.Clear();

        string firstLine = lines[0];
        string[] scoreParts = firstLine.Split(" ~ ");

        if (int.TryParse(scoreParts[scoreParts.Length - 1], out int parsedScore))
        {
            _score = parsedScore;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            string[] part = line.Split(new[] {": "}, 2, StringSplitOptions.None);
            if (part.Length < 2)
            {
                continue;
            }

            string type = part[0];
            string[] data = part[1].Split(" ~ ");
            for (int j = 0; j < data.Length; j++)
            {
                data[j] = data[j];
            }

            try
            {
                if (type == "SimpleGoal" && data.Length >= 4)
                {
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                }

                else if (type == "EternalGoal" && data.Length >= 3)
                {
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }

                else
                {
                    _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Skipping line {i+1}: {ex.Message}");
            }
        }
    }
}