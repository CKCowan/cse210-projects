
public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private int _promptsCount;
    private int _questionsCount;

    static Random random = new Random();

    public Reflecting(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void Run(){
        
            Console.WriteLine($"\n\nConsider the following prompt:");
            string prompt = GetRandomPrompt();
            DisplayPrompt(prompt);

            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            DateTime currentTime = DateTime.Now;
            while(currentTime < futureTime){
            string question = GetRandomQuestion();
            DisplayQuestions(question);

            currentTime = DateTime.Now;
        }
        
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        _promptsCount = _prompts.Count();
        int index = random.Next(_promptsCount);
        return _prompts[index];
    }
    public string GetRandomQuestion(){
        _questionsCount = _prompts.Count();
        int index = random.Next(_questionsCount);
        return _questions[index];
    }
    public void DisplayPrompt(string prompt){
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestions(string question){
        Console.WriteLine(question);
        ShowSpinner(10);
    }

    

}