namespace ResumeNameSpace;

using JobNameSpace;

public class Resume
{
    public string? _name;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Work Experience:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}