using System;

class Program
{
    /*
    Eternal Quest Program - Exceeds Requirements

    This program includes several features that go beyond the basic requirements:

    1. Leveling System: Users gain experience points (XP) along with regular points. 
    Every 1000 XP levels them up, providing a sense of progression.

    2. Visual Indicators: The program uses [X] and [ ] to clearly show completed 
    and incomplete goals, making it easy to see progress at a glance.

    3. Detailed Progress Tracking: For checklist goals, it shows exactly how many 
    times the goal has been completed out of the target (e.g., "3/5").

    4. Robust File Handling: The save/load system preserves all goal types, 
    progress, score, level, and experience between sessions.

    5. Enhanced User Feedback: When recording events, the program provides 
    immediate feedback about points earned and level-ups.

    6. Comprehensive Goal Details: Each goal shows its name, description, 
    and current status in the list view.

    7. Input Validation: The program includes basic error handling for 
    invalid menu choices and file operations.
    */
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}