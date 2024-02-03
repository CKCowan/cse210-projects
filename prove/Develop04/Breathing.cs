
public class Breathing : Activity
{
    public void Run(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        // Thread.Sleep(1000);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            Console.Write($"\n\nBreathe in...  ");
            ShowCountDown(5);

            Console.Write($"\n\nNow breathe out...  ");
            ShowCountDown(5);

            currentTime = DateTime.Now;
        }
        
        DisplayEndingMessage();
        
        
    }

    public Breathing(string name, string description) : base(name, description)
    {
        
    }
}