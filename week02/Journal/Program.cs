using System;

class Program
{
    /// <summary>
    /// Entry point for the Journal Program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    /// <remarks>
    /// This method initializes a new Journal and enters a loop that displays a menu 
    /// to the user, allowing them to add entries, display entries, save the journal 
    /// to a file, load a journal from a file, or quit the program. The user's 
    /// choice is processed and the corresponding action is taken.
    /// 
    /// **Exceeding Requirements:**
    /// This program exceeds the core requirements by implementing JSON as the storage format for journal entries.
    /// JSON (JavaScript Object Notation) is a lightweight, human-readable, and widely-used data interchange format.
    /// By using JSON, the program achieves the following benefits:
    /// 
    /// 1. **Readability**: JSON files are easy to read and understand, both for humans and machines.
    /// 2. **Flexibility**: JSON supports complex data structures, making it easier to extend the program in the future.
    /// 3. **Compatibility**: JSON is supported by many programming languages and tools, allowing the journal files to be easily imported or exported.
    /// 4. **Structured Data**: JSON ensures that the journal entries are stored in a structured format, preserving the relationship between date, prompt, and response.
    /// 
    /// For example, a journal entry is stored in the following JSON format:
    /// [
    ///   {
    ///     "_date": "2025/03/15",
    ///     "_promptText": "What was the best part of my day?",
    ///     "_response": "This morning"
    ///   },
    ///   {
    ///     "_date": "2025/03/15",
    ///     "_promptText": "Who was the most interesting person I interacted with today?",
    ///     "_response": "Jhendry"
    ///   }
    /// ]
    /// 
    /// This approach not only meets the core requirements but also enhances the program's functionality and usability.
    /// </remarks>
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running) 
        {
            // Display the menu
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");

            // Get the user's choice
            string choice = Console.ReadLine();
            // Process the user's choice
            switch (choice)
            {
                // Add an entry
                case "1":
                    string date = DateTime.Now.ToString("yyyy/MM/dd");
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string response = Console.ReadLine();
                    Entry entry = new Entry(date, promptText, response);
                    journal.AddEntry(entry);

                    // clear the console
                    Console.Clear();
                    break;

                // Display all entries
                case "2":
                    journal.DispayAll();
                    break;

                // Save to file
                case "3":
                    Console.Write("Enter a file name: ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    // clear the console
                    Console.Clear();
                    break;

                // Load from file
                case "4":
                    Console.Write("Enter a file name: ");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    // clear the console
                    Console.Clear();
                    break;

                // Quit
                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}