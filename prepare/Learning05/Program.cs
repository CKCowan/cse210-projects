using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square square = new Square("red", 4);
        shapes.Add(square);
        // string square_color = square.GetColor();
        // double square_area = square.GetArea();
        // Console.WriteLine(square_area);
        // Console.WriteLine(square_color);

        Rectangle rectangle = new Rectangle("blue", 4, 8);
        shapes.Add(rectangle);
        // string rect_color = rectangle.GetColor();
        // double rect_area = rectangle.GetArea();
        // Console.WriteLine(rect_area);
        // Console.WriteLine(rect_color);

        Circle circle = new Circle("green", 4);
        shapes.Add(circle);
        // string circle_color = circle.GetColor();
        // double circle_area = circle.GetArea();
        // Console.WriteLine(circle_area);
        // Console.WriteLine(circle_color);

        foreach(Shape shape in shapes){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}