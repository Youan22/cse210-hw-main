using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("green", 4, 6));
        shapes.Add(new Circle("blue", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: {0}", shape.Color);
            Console.WriteLine("Area: {0}\n", shape.GetArea());
        }
    }
}
