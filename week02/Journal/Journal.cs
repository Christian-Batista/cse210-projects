using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries { get; set; } = new List<Entry>();

    /// <summary>
    /// Construct a new Journal.
    /// </summary>
    public Journal()
    {
        _entries = new List<Entry>();
    }

    /// <summary>
    /// Add an entry to the journal.
    /// </summary>
    /// <param name="newEntry">The entry to add.</param>
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    /// <summary>
    /// Display all entries in the journal.
    /// </summary>
    public void DispayAll()
    {
       foreach (Entry entry in _entries)
       {
           entry.Display();
       }
    }

    /// <summary>
    /// Save the journal to a file.
    /// </summary>
    /// <param name="file">The file name to save the journal to.</param>
    /// <remarks>
    /// This method creates a folder named "files" in the parent directory if it doesn't exist.
    /// It then serializes the list of entries to JSON and writes it to a file with the given name
    /// in the "files" folder.
    /// </remarks>
    public void SaveToFile(string file)
    {
        // Create the folder if it doesn't exist
        string folderPath = Path.Combine("..", "..", "..", "files");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        // Combine the folder path with the file name
        string filePath = Path.Combine(folderPath, file);

        // Serialize the list of entries to JSON
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });

        // Write the JSON to the file
        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Load a journal from a file.
    /// </summary>
    /// <param name="file">The file name to load the journal from.</param>
    /// <remarks>
    /// This method reads a file from the "files" folder. If the file exists, it deserializes
    /// the JSON in the file into a list of entries and displays each one. If the file doesn't
    /// exist, it prints a message to the console.
    /// </remarks>
    public void LoadFromFile(string file)
    {
        // Combine the folder path with the file name
        string folderPath = Path.Combine("..", "..", "..", "files");
        string filePath = Path.Combine(folderPath, file);

        if (File.Exists(filePath))
        {
            // Reead the JSON from the file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON into a list of entries
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }

        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}