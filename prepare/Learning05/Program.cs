using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square square = new("purple", 16);
        shapes.Add(square);

        Rectangle rectangle = new("blue", 3, 10);
        shapes.Add(rectangle);

        Circle circle = new("yellow", 20);
        shapes.Add(circle);
       
       foreach(Shape s in shapes)
       {
        string color = s.GetColor();
        double area = s.GetArea();
        Console.WriteLine($"The {color} shape has an area of {area}.");
       }
    }
}