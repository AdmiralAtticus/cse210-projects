using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("Red", 4);

        Rectangle rect = new Rectangle("Blue", 5, 3);

        Circle circ = new Circle("Green", 2.5);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(rect);
        shapes.Add(circ);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea()}");
        }

    }
}