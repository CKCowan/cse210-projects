using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal Program!");
        
        List<string> menuChoices = new List<string> {"Write", "Display", "Load", "Save", "Quit"};
        
        Journal journal = new Journal();
        
        DisplayMenu(menuChoices, journal);
        
        
        
        
        static void DisplayMenu(List<string> menuChoices, Journal journal)
        {
            Console.WriteLine("Please select one of the following choices:");
            for(int i=0; i<menuChoices.Count; i++){
                int choiceNumber = i + 1;
                Console.WriteLine($"{choiceNumber}. {menuChoices[i]}");
            }
            Console.Write("What would you like to do? ");
            string selection = Console.ReadLine();

            processSelection(journal, selection, menuChoices);
        }

        static void processSelection(Journal journal, string userSelection, List<string> menuChoices){
            string myJournalFile = "cowanJournal.txt";

            if(userSelection == "1"){
                DateTime date = DateTime.Now;

                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string text = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = text
                };
                

                
                journal.AddEntry(newEntry);
                DisplayMenu(menuChoices, journal);
                
            }
            else if(userSelection == "2"){
                journal.DisplayAll();
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "3"){
                journal.LoadFromFile(myJournalFile);
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "4"){
                journal.SaveToFile(myJournalFile);
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "5"){
                Console.WriteLine("See you tomorrow!");
                Environment.Exit(0);
            }            
        }

        
    }
}