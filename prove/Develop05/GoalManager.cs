using System.IO;

public class Manager
{
    public List<string> _menuChoices;

    public List<string> _goalChoices;
    public List<Goal> _goals;
    private int _score;

    public string _type;

    public Manager()
    {
        _menuChoices = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _goalChoices = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
        _goals = new List<Goal>();
        _score = 0;
    }
    
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start(){
        DisplayPlayerInfo();
        
        DisplayMenu(_menuChoices);

        Console.Write("Select a choice from the menu: ");

        
        // ProcessMenuChoice(menuChoices, _selection);
    }

    // Displays the players current score.
    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.\n");
    }

    // Lists the names of each of the goals.
    public void ListGoalNames(){
        
        // Provide instruction to user
        Console.WriteLine("Menu Options:");
        // Loop through menu choices, using "i" to create numbers for each choice
        for(int i=0; i<_goalChoices.Count; i++){
            int choiceNumber = i + 1;
            Console.WriteLine($"{choiceNumber}. {_goalChoices[i]}");
        }
        
    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails(){
        for(int i = 0; i < _goals.Count(); i++){
            int number = i + 1;
            string detailString = _goals[i].GetDetailsString();
            if(_goals[i].IsComplete()){
                Console.WriteLine($"{number}. [x] {detailString}");
            }
            else{
                Console.WriteLine($"{number}. [ ] {detailString}");
            }
        }
    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal(){
        Console.WriteLine("\nThe types of goals are:");
        ListGoalNames();
        Console.Write("What type of goal would you like to create? ");
        string selectedType = Console.ReadLine();
        _type = GetSelectionDesc(_goalChoices, selectedType);
        // Console.WriteLine(_type);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(_type == "Simple Goal"){
            Simple simple = new Simple(name,desc,points,_type);
            _goals.Add(simple);
        }
        else if(_type == "Eternal Goal"){
            _type = "eternal";
            Eternal eternal = new Eternal(name, desc, points, _type);
            _goals.Add(eternal);
        }
        else if(_type == "Checklist Goal"){
            Console.Write("How many time does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _type = "checklist";
            Checklist checklist = new Checklist(name, desc, points, _type, target, bonus);
            _goals.Add(checklist);
        }
    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent(){
        
    }

    // Saves the list of goals to a file.
    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine(_score);
            for(int i = 0; i < _goals.Count(); i++){
                string line = _goals[i].GetStringRepresentation(_goals[0]._shortName, _goals[0]._description, _goals[0]._points);
                outputFile.WriteLine(line);
            }
            
        }
    }

    // Loads the list of goals from a file.
    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        string goalDetails;
        List<string> goalDetailsArry = new List<string>();
        string goalType;

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            goalType = parts[0];
            goalDetails = parts[1];

            goalDetailsArry.Add(goalDetails);
        }

        

    }

    public void DisplayMenu(List<string> menuChoices)
    {
        // Provide instruction to user
        Console.WriteLine("Menu Options:");
        // Loop through menu choices, using "i" to create numbers for each choice
        for(int i=0; i<menuChoices.Count; i++){
            int choiceNumber = i + 1;
            Console.WriteLine($"{choiceNumber}. {menuChoices[i]}");
        }
    }

    public string GetSelectionDesc(List<string> menuChoices, string selection){
        int selectionIndex = int.Parse(selection) - 1;
        // Console.WriteLine(selectionIndex);
        string selectionDesc = menuChoices[selectionIndex];

        return selectionDesc;
        
    }

    public virtual string createLoadedGoal(string details){
        string[] detailsArray = details.Split(",");

        string name;
        string description;
        string points;
        foreach (string detail in detailsArray){
            string[] parts = detail.Split(",");

            name = parts[0];
            description = parts[1];
            points = parts[2];

        }


    }

    

}