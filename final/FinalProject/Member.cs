
public class Member
{
    public string _firstName;
    public string _lastName;

    public Member(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public virtual void ConfirmAction(string firstname, string lastname, string action){
        Console.WriteLine($"{firstname} {lastname} assigned as {action}.\n");
    }

}