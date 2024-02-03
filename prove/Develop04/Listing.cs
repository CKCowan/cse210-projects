
public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;
    public List<string> _userList;
    private string _listItem;
    Random random = new Random();
    private int _promptsCount;

    public Listing(string name, string description) : base(name, description)
    { 
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _userList = new List<string>();
        
    }
    public void Run(){
        
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            Console.Write("\n>");
            _listItem = Console.ReadLine();
            _userList.Add(_listItem);

            currentTime = DateTime.Now;
        }
        
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        _promptsCount = _prompts.Count();
        int index = random.Next(_promptsCount);
        return _prompts[index];
    }
    public List<string> GetListFromUser(){
        return _userList;
    }
}