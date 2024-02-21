
public class Prayer : Member 
{
    private string _order;
    public Prayer(string firstName, string lastName, string order) : base(firstName, lastName)
    {
        _order = order;
    }

    public string getOrder(){
        return _order;
    }
}