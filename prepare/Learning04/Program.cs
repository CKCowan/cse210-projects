using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Chris", "C#");
        // Console.WriteLine(assignment.GetSummary());

        // Math math = new Math("Chris", "C#", "7.3", "8-19");
        // Console.WriteLine(math.GetSummary());
        // Console.WriteLine(math.GetHomeworkList());

        Writing writing = new Writing("Chris", "Programming Code", "Coding is Fun!");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInfo());
    }
}