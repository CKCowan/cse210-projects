
public class Entry 
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;
    public void Display(Entry entry){
        Console.WriteLine($"The Date of this entry was: {entry._date}");
        Console.WriteLine($"The prompt was: {entry._promptText}");
        Console.WriteLine($"Your entry: {entry._entryText}");
    }
    
}