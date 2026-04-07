using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Shapes.Square square = new Shapes.Square();
        square.SetColor("Red");
        square.SetSide(5);

        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");
        Console.WriteLine();

        Shapes.Rectangle rectangle = new Shapes.Rectangle();
        rectangle.SetColor("Blue");
        rectangle.SetLength(10);
        rectangle.SetWidth(5);

        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        Console.WriteLine();

        Shapes.Circle circle = new Shapes.Circle();
        circle.SetColor("Cyan");
        circle.SetRadius(7);

        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine();
    }
}