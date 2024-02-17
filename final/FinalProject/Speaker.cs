
public class Speaker : Member
{
    private string _topic;
    private string _speakingOrder;

    public Speaker (string firstName, string lastName, string topic, string order) : base(firstName, lastName)
    {
        _topic = topic;
        _speakingOrder = order;
    }

    
}