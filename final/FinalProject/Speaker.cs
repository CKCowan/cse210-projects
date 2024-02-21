
public class Speaker : Member
{
    private string _topic;
    private string _speakingOrder;

    private List<Speaker> _speakers = new List<Speaker>();

    public Speaker (string firstName, string lastName, string topic, string order) : base(firstName, lastName)
    {
        _topic = topic;
        _speakingOrder = order;
    }

    public override void ConfirmAction(string firstname, string lastname, string action)
    {
        Console.WriteLine($"{firstname} {lastname} added as {_speakingOrder}. Topic is {_topic}.\n");
    }

    public List<Speaker> GetSpeakers(){
        return _speakers;
    }

    public string getTopic(){
        return _topic;
    }
    public string getOrder(){
        return _speakingOrder;
    }

    
}