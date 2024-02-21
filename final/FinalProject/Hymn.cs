
public class Hymn 
{
    private string _title;
    private int _number;
    private string _hymnOrder;

    public Hymn(string order, string title, int number){
        _title = title;
        _number = number;
        _hymnOrder = order;
    }

    public string getOrder(){
        return _hymnOrder;
    }
    public string getTitle(){
        return _title;
    }
    public int getNumber(){
        return _number;
    }
}