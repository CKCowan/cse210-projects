using System;

class Program
{
    
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        string _selection = "";

        while(_selection != "6"){
            manager.Start();
        
            _selection = Console.ReadLine();

            string selectionDescription = manager.GetSelectionDesc(manager._menuChoices, _selection);
            
            if(selectionDescription == "Create New Goal"){
                manager.CreateGoal();
            }   
            else if(selectionDescription == "List Goals"){
                manager.ListGoalDetails();
            } 
            else if(selectionDescription == "Save Goals"){
                manager.SaveGoals();
            } 
        }
          
        
    }
}