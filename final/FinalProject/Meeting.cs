
public class Meeting 
{
    private List<string> _menuChoices;

    private Presiding _presiding;
    private string _conducting;

    private List<Speaker> _speakers = new List<Speaker>();
    private List<Hymn> _hymns = new List<Hymn>();
    private List<Prayer> _prayers = new List<Prayer>();

    private List<string> _bishopricTitles = new List<string>();
    private List<string> _speakingOrder = new List<string>();
    private List<string> _hymnOrder = new List<string>();
    private List<string> _prayerOrder = new List<string>();

    public Meeting()
    {
        _menuChoices = new List<string> {"Assign Presiding", "Assign Conducting", "Add Speaker", "Add Hymn", "Assign Prayer", "Display Program", "Quit"};
        _bishopricTitles = new List<string> {"Bishop", "1st Counselor", "2nd Counselor"};
        _speakingOrder = new List<string> {"1st Speaker", "2nd Speaker", "3rd Speaker"};
        _hymnOrder = new List<string> {"Opening", "Sacrament", "Intermediate", "Closing"};
        _prayerOrder = new List<string> {"Opening", "Closing"};
    }

    public void DisplayMenu(List<string> menuChoices){
        // Provide instruction to user
        Console.WriteLine("\nProgram Options:");
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
    public void AddHymn(Hymn hymn){
        _hymns.Add(hymn);
    }
    public void AddPrayer(Prayer prayer){
        _prayers.Add(prayer);
    }


    public void DisplayMeetingInfo(){
        if(_presiding != null){
            Console.WriteLine($"Presiding: {_presiding.GetTitle()}, {_presiding._firstName} {_presiding._lastName}");
        }
        if(_conducting != null){
            Console.WriteLine(_conducting);
        }

        Console.WriteLine();

        if(_hymns.Count() > 0){
            foreach(Hymn hymn in _hymns){
                if(hymn.getOrder() == "Opening"){
                    Console.WriteLine($"{hymn.getOrder()} hymn: {hymn.getNumber()} - {hymn.getTitle()}");
                }
            }
        }

        if(_prayers.Count() > 0){
            foreach(Prayer prayer in _prayers){
                if(prayer.getOrder() == "Opening"){
                    Console.WriteLine($"{prayer.getOrder()} Prayer - {prayer._firstName} {prayer._lastName}");
                }
            }
        }

        Console.WriteLine();

        if(_hymns.Count() > 0){
            foreach(Hymn hymn in _hymns){
                if(hymn.getOrder() == "Sacrament"){
                    Console.WriteLine($"{hymn.getOrder()} hymn: {hymn.getNumber()} - {hymn.getTitle()}");
                }
            }
        }

        Console.WriteLine();
        
        if(_speakers.Count() > 0){
            foreach(Speaker speaker in _speakers){
                if(speaker.getOrder() == "1st Speaker"){
                    Console.WriteLine($"{speaker.getOrder()}: {speaker._firstName} {speaker._lastName}");
                }
            }
        }

        if(_speakers.Count() > 0){
            foreach(Speaker speaker in _speakers){
                if(speaker.getOrder() == "2nd Speaker"){
                    Console.WriteLine($"{speaker.getOrder()}: {speaker._firstName} {speaker._lastName}");
                }
            }
        }

        Console.WriteLine();
        
        if(_hymns.Count() > 0){
            foreach(Hymn hymn in _hymns){
                if(hymn.getOrder() == "Intermediate"){
                    Console.WriteLine($"{hymn.getOrder()} hymn: {hymn.getNumber()} - {hymn.getTitle()}");
                }
            }
        }

        Console.WriteLine();
        
        if(_speakers.Count() > 0){
            foreach(Speaker speaker in _speakers){
                if(speaker.getOrder() == "3rd Speaker"){
                    Console.WriteLine($"{speaker.getOrder()}: {speaker._firstName} {speaker._lastName}");
                }
            }
        }

        Console.WriteLine();
        
        if(_hymns.Count() > 0){
            foreach(Hymn hymn in _hymns){
                if(hymn.getOrder() == "Closing"){
                    Console.WriteLine($"{hymn.getOrder()} hymn: {hymn.getNumber()} - {hymn.getTitle()}");
                }
            }
        }

        if(_prayers.Count() > 0){
            foreach(Prayer prayer in _prayers){
                if(prayer.getOrder() == "Closing"){
                    Console.WriteLine($"{prayer.getOrder()} Prayer - {prayer._firstName} {prayer._lastName}");
                }
            }
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
    public List<string> getHymnOrder(){
        return _hymnOrder;
    }
    public List<string> getPrayerOrder(){
        return _prayerOrder;
    }
    public string GetConducting(){
        return _conducting;
    }
}