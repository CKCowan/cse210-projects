
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    Entry displayEntries = new Entry();
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
        Console.WriteLine("Journal entry added!");
    }

    public void DisplayAll(){
        foreach(Entry entry in _entries){
            displayEntries.Display(entry);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file){
        using(StreamWriter outputFile = new StreamWriter(file)){
            foreach(Entry entry in _entries){
            outputFile.WriteLine($"The Date of this entry was: {entry._date}");
            outputFile.WriteLine($"The prompt was: {entry._promptText}");
            outputFile.WriteLine($"Your entry: {entry._entryText}");
        }
        }
        Console.WriteLine("Saved to file!");
    }

    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}