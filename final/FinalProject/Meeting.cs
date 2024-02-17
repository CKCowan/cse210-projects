
public class Meeting 
{
    private List<string> _menuChoices;

    private Presiding _presiding;
    private string _conducting;

    private List<Speaker> _speakers = new List<Speaker>();

    private List<string> _bishopricTitles = new List<string>();
    private List<string> _speakingOrder = new List<string>();

    public Meeting()
    {
        _menuChoices = new List<string> {"Assign Presiding", "Assign Conducting", "Add Speaker", "Add Hymn", "Assign Prayer", "Display Program", "Quit"};
        _bishopricTitles = new List<string> {"Bishop", "1st Counselor", "2nd Counselor"};
        _speakingOrder = new List<string> {"1st Speaker", "2nd Speaker", "3rd Speaker"};
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

    // public void SetSpeakers(List<Speaker> speakers){
    //     _speakers = speakers;
    // }

    public void AddSpeaker(Speaker speaker){
        _speakers.Add(speaker);
    }


    public void DisplayMeetingInfo(){
        Console.WriteLine($"Presiding: {_presiding.GetTitle()}, {_presiding._firstName} {_presiding._lastName}");
        Console.WriteLine(_conducting);
        foreach(Speaker speaker in _speakers){
            Console.WriteLine($"{speaker.getOrder()} - {speaker._firstName} {speaker._lastName}: {speaker.getTopic()}");
        }
    }

    public List<string> getMenuChoices(){
        return _menuChoices;
    }
    public List<string> getBishopricTitles(){
        return _bishopricTitles;
    }
    public List<string> getSpeakingOrder(){
        return _speakingOrder;
    }
}