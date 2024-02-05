using System.Security.Cryptography.X509Certificates;

public class Square : Shape
{
    private int _side;
    public Square(string color, int side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}