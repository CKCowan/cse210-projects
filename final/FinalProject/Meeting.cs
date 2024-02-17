
public class Meeting 
{
    private List<string> _menuChoices;

    private Presiding _presiding;
    private string _conducting;

    private List<string> _bishopricTitles = new List<string>();

    public Meeting()
    {
        _menuChoices = new List<string> {"Assign Presiding", "Assign Conducting", "Add Speaker", "Add Hymn", "Assign Prayer", "Display Program", "Quit"};
        _bishopricTitles = new List<string> {"Bishop", "1st Counselor", "2nd Counselor"};
        
    }

    public void DisplayMenu(List<string> menuChoices){
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

    public void SetPresiding(Presiding presiding){
        _presiding = presiding;
    }
    public void SetConducting(Conducting conducting){
        string title = conducting.getTitle();
        string member = conducting.getBishopricMember(title);
        _conducting = $"Conducting: {title} {member}";
    }


    public void DisplayMeetingInfo(){
        Console.WriteLine($"Presiding: {_presiding._firstName} {_presiding._lastName}, {_presiding.GetTitle()}");
        Console.WriteLine(_conducting);

    }

    public List<string> getMenuChoices(){
        return _menuChoices;
    }
    public List<string> getBishopricTitles(){
        return _bishopricTitles;
    }
}