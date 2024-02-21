
public class Presiding : Member
{
    private string _title;

    public Presiding(string firstName, string lastName, string title) : base(firstName, lastName)
    {
        _title = title;
    }

    public string GetTitle(){
        return _title;
    }


}