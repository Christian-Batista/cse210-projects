public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        GetRandomPrompt();
        Console.WriteLine("You will begin shortly...");
        ShowCountDown(5);
        
        List<string> items = GetListFromUser();
        _count = items.Count;
        
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.WriteLine("Start listing items now:");
        while (DateTime.Now < endTime)
        {
            items.Add(Console.ReadLine());
        }
        
        return items;
    }
}