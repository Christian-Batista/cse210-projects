public class Assignment
{
    private string _studentName = "";
    private string topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        this.topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {topic}";
    }
}