using System.Text.Json.Serialization;
public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _response { get; set; }

    // Construct without parameters
    public Entry() { }
    
    /// <summary>
    /// Construct with date, prompt text, and response.
    /// </summary>
    /// <param name="date">The date of the journal entry.</param>
    /// <param name="promptText">The prompt text for the journal entry.</param>
    /// <param name="response">The response to the prompt.</param>
    public Entry(string date, string promptText, string response)
    {
        _date = date;
        _promptText = promptText;
        _response = response;
    }


    /// <summary>
    /// Displays the journal entry, including the date, prompt text, and response, to the console.
    /// </summary>

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }
}