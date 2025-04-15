using System;
using System.IO;

public class FileHandler
{
    public static void SaveToFile(string filename, List<Goal> goals, int score, int level, int experience)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            writer.WriteLine(level);
            writer.WriteLine(experience);
            
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public static (List<Goal>, int, int, int) LoadFromFile(string filename)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        int level = 1;
        int experience = 0;

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                score = int.Parse(reader.ReadLine());
                level = int.Parse(reader.ReadLine());
                experience = int.Parse(reader.ReadLine());
                
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
                            goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            var eternalGoal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                            for (int i = 0; i < int.Parse(details[3]); i++) eternalGoal.RecordEvent();
                            goals.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(
                                details[0], 
                                details[1], 
                                int.Parse(details[2]), 
                                int.Parse(details[4]), 
                                int.Parse(details[3]));
                            for (int i = 0; i < int.Parse(details[5]); i++) checklistGoal.RecordEvent();
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
        
        return (goals, score, level, experience);
    }
}