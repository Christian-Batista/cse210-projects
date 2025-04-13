using System;

class Program
{
    static void Main(string[] args)
    {

        /*
        * EXCEEDING REQUIREMENTS:
        * 1. Added visual progress bar with percentage countdown
        * 2. Progress bar shows completion status with clean "Done" message
        * 3. Reusable component that can be used across all activities
        */
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();
            Activity activity = null;
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }
            
            activity.Run();
        }
    }
}