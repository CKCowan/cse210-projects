using System;

class Program
{
    static void Main(string[] args)
    {
        // Add scripture reference(s) to memorize
        string book = "1 Nephi";
        int chapter = 1;
        int verse = 12;
        Reference reference = new Reference(book, chapter, verse);

        string text = "And it came to pass that as he read, he was filled with the Spirit of the Lord.";
        Scripture scripture = new Scripture(reference, text);

        // Display scripture reference and instructions to user
        string scriptureReference = reference.GetDisplayText();

        Console.WriteLine($"{scriptureReference} {text}\n");

        string userChoice = "";
        while(userChoice != "quit"){
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userChoice = Console.ReadLine();
        
            Console.Clear();

            scripture.HideRandomWords(5);

            if(scripture.IsCompletelyHidden() == true){
                Console.WriteLine("You did it! GREAT JOB!!!");
                Environment.Exit(0);
            }
            else if(scripture.IsCompletelyHidden() == false){
                Console.Write(scripture.GetDisplayText() + "\n");
            }
            
        }

        Console.Write("Great job working on your scripture memorization!");
        Environment.Exit(0);

        
    }
}