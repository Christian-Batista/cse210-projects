using System;
using System.Net;

class Program
{
    public static bool UseKilometers = false;
    static void Main(string[] args)
    {
        // Create activities
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 3.0),
                new Cycling(new DateTime(2022, 11, 3), 30, 9.7),
                new Swimming(new DateTime(2022, 11, 3), 30, 20)
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            // Optional: Test with metric system
            Console.WriteLine("\nSwitching to metric system:");
            UseKilometers = true;
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    
}