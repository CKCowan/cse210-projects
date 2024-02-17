
public class Prayer : Member 
{
    private string _description;
    public Prayer(string firstName, string lastName, string description) : base(firstName, lastName)
    {
        _description = description;
    }
}