using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "red");
        Rectangle rectangle = new Rectangle(2, 3, "yellow");
        Circle circle = new Circle(2, "blue");

        List<Shape> shapes = new List<Shape>() { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}