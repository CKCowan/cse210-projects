using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to the Journal Program!");
        // Create variable to store list of menu options
        List<string> menuChoices = new List<string> {"Write", "Display", "Load", "Save", "Quit"};
        // Create instance of journal class
        Journal journal = new Journal();
        // Loop through menu choices to display them and prompt user to make a selection
        DisplayMenu(menuChoices, journal);
        
        static void DisplayMenu(List<string> menuChoices, Journal journal)
        {
            // Provide instruction to user
            Console.WriteLine("Please select one of the following choices:");
            // Loop through menu choices, using "i" to create numbers for each choice
            for(int i=0; i<menuChoices.Count; i++){
                int choiceNumber = i + 1;
                Console.WriteLine($"{choiceNumber}. {menuChoices[i]}");
            }
            // Prompt user to make a selection
            Console.Write("What would you like to do? ");
            // Save user selection
            string selection = Console.ReadLine();
            // Process user selection
            processSelection(journal, selection, menuChoices);
        }

        static void processSelection(Journal journal, string userSelection, List<string> menuChoices){
            // Set variable for journal file
            string myJournalFile = "cowanJournal.txt";
            // Use if/else if statements for each menu choice
            if(userSelection == "1"){
                // Set variable for current date
                DateTime date = DateTime.Now;
                // Create instance of promptgenerator
                PromptGenerator promptGenerator = new PromptGenerator();
                // Store random prompt into variable
                string prompt = promptGenerator.GetRandomPrompt();
                // Display prompt to user
                Console.WriteLine(prompt);
                Console.Write("> ");
                // Save user entry to variable
                string text = Console.ReadLine();
                // Create instance of entry and store entry values as entry object
                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = text
                };
                // Add entry object to journal
                journal.AddEntry(newEntry);
                // Display menu choices to user
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "2"){
                // Display user entries
                journal.DisplayAll();
                // Display menu choices to user
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "3"){
                // Load file and display to user
                journal.LoadFromFile(myJournalFile);
                // Display menu choices to user
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "4"){
                // Save journal entries to file
                journal.SaveToFile(myJournalFile);
                // Display menu choices to user
                DisplayMenu(menuChoices, journal);
            }
            else if(userSelection == "5"){
                // Display exit message to user
                Console.WriteLine("See you tomorrow!");
                // Exit program
                Environment.Exit(0);
            }            
        }

        
    }
}