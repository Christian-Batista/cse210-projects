public class PromptGenerator
{
    public List<string> _prompts;

    /// <summary>
    /// Constructor for the PromptGenerator class.
    /// Initializes the list of prompts used by the GetRandomPrompt() method.
    /// </summary>
    public PromptGenerator()
    {
        // Initialize the list of prompts in the constructor
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What is my favorite thing about today?",
            "What did I learn today?",
            "What am I grateful for today?"
        };
    }

    /// <summary>
    /// Gets a random prompt from the list of prompts.
    /// </summary>
    /// <returns>A random prompt as a string.</returns>
    public string GetRandomPrompt()
    {
        // Get a random prompt from the list of prompts
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        // Return the random prompt
        return _prompts[index];
    }
}