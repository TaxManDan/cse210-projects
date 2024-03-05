using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        var square1 = new Square(5);
        square1.SetColor("Red");
        shapes.Add(square1);
        var rectangle1 = new Rectangle(3, 4);
        rectangle1.SetColor("Blue");
        shapes.Add(rectangle1);
        var circle1 = new Circle(6);
        circle1.SetColor("Green");
        shapes.Add(circle1);

        foreach (Shape shape in shapes){
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }

    }
}