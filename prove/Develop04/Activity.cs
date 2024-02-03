
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        // _name = "Breathing";
        // _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        // _duration = 5;

        _name = name;
        _description = description;
    }

    public void SetActivityParams(string name, string description){
        _name = name;
        _description = description;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.Write($"Welcome to the {_name} Activity.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("\n\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds){
        // Console.WriteLine("Get ready...");

        for(int i = 0; i<2; i++){
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
        }
        
    }
    public void ShowCountDown(int second){
        for(int i = second; i > 0; i--){
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }
        
}