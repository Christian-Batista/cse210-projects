using System;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetProgressText()
    {
        int hiddenCount = _words.Count(word => word.IsHidden());
        int totalWords = _words.Count;
        double percentage = (double)hiddenCount / totalWords * 100;
        return $"Memorized: {totalWords - hiddenCount}/{totalWords} ({percentage:F2}%)";
    }
}