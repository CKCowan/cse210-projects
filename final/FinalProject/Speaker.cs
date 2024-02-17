
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

    // public void AddSpeaker(Speaker speaker){
    //     ;
    // }

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