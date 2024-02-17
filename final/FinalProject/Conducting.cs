
public class Conducting
{
    private List<Member> _bishopric = new List<Member>();
    private string _title;


    public Conducting(string title)
    {
        _bishopric.Add(new Member("Harry", "Potter"));
        _bishopric.Add(new Member("Ronald", "Weasley"));
        _bishopric.Add(new Member("Hermoine", "Grainger"));
        
        _title = title;
    }


    public string getTitle(){
        return _title;
    }
    public string getBishopricMember(string title){
        if(title == "Bishop"){
            return $"{_bishopric[0]._firstName} {_bishopric[0]._lastName}";
        } 
        else if(title == "1st Counselor"){
            return $"{_bishopric[1]._firstName} {_bishopric[1]._lastName}";
        } 
        else if(title == "Bishop"){
            return $"{_bishopric[2]._firstName} {_bishopric[2]._lastName}";
        } 
        else{
            return "";
        }
    }
}