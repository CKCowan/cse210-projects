using System;

class Program
{
    static void Main(string[] args)
    {
        // Display menu
        Console.WriteLine("Menu Options:\n");
        // Create variable to store list of menu options
        List<string> menuChoices = new List<string> {"Start Breathing Activity", "Start Reflecting Activity", "Start Listing Activity", "Quit"};

        // string breatheName = "Breathing";
        // string breatheDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
        // string reflectName = "Reflecting";
        // string reflectDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        // Loop through menu choices to display them and prompt user to make a selection
        DisplayMenu(menuChoices);
        
        static void DisplayMenu(List<string> menuChoices)
        {
            // Provide instruction to user
            Console.WriteLine("Please select one of the following choices:\n");
            // Loop through menu choices, using "i" to create numbers for each choice
            for(int i=0; i<menuChoices.Count; i++){
                int choiceNumber = i + 1;
                Console.WriteLine($"{choiceNumber}. {menuChoices[i]}");
            }
            // Prompt user to make a selection
            Console.Write("\nSelect a choice from the menu: ");
            // Save user selection
            string selection = Console.ReadLine();
            // Process user selection
            if(selection == "4"){
                Console.WriteLine("Stay calm.");
                Environment.Exit(0);
            }
            else{
                StartActivity(selection);
            }
            
        }

        static void StartActivity(string selection){
            Console.Clear();

            // Activity activity = new Activity();
            if(selection == "1"){
                string breatheName = "Breathing";
                string breatheDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing breathing = new Breathing(breatheName, breatheDesc);
                
                breathing.DisplayStartingMessage();
                
                int duration = int.Parse(Console.ReadLine());
                breathing.SetDuration(duration);
                Console.WriteLine("Get ready... ");
                breathing.ShowSpinner(5000);

                breathing.Run();
            }
            else if(selection == "2"){
                string reflectName = "Reflecting";
                string reflectDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                // activity.SetActivityParams("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Reflecting reflecting = new Reflecting(reflectName, reflectDesc);
                reflecting.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                reflecting.SetDuration(duration);
                Console.WriteLine("Get ready... ");
                reflecting.ShowSpinner(5000);

                reflecting.Run();
            }
            else if(selection == "3"){
                string listingName = "Listing";
                string listingDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                // activity.SetActivityParams("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Listing listing = new Listing(listingName, listingDesc);
                listing.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                listing.SetDuration(duration);
                Console.WriteLine("Get ready... ");
                listing.ShowSpinner(5000);

                listing.Run();
            }
        }

        DisplayMenu(menuChoices);

        
    }
}