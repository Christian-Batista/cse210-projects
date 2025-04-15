using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _experience;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _experience = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nYou are Level {_level} with {_score} points ({_experience} XP)");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            int pointsEarned = _goals[goalNumber].RecordEvent();
            _score += pointsEarned;
            _experience += pointsEarned;
            
            // Level up logic
            int newLevel = _experience / 1000 + 1;
            if (newLevel > _level)
            {
                _level = newLevel;
                Console.WriteLine($"\nLEVEL UP! You are now Level {_level}!");
            }
            
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_experience);
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _level = int.Parse(reader.ReadLine());
                _experience = int.Parse(reader.ReadLine());
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string[] details = parts[1].Split(',');
                    
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                            if (bool.Parse(details[3])) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            var eternalGoal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                            for (int i = 0; i < int.Parse(details[3]); i++) eternalGoal.RecordEvent();
                            _goals.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(
                                details[0], 
                                details[1], 
                                int.Parse(details[2]), 
                                int.Parse(details[4]), 
                                int.Parse(details[3]));
                            for (int i = 0; i < int.Parse(details[5]); i++) checklistGoal.RecordEvent();
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            
            Console.WriteLine("Goals loaded successfully.");
            ListGoalDetails();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}