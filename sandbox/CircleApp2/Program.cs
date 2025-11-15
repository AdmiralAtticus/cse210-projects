class Program
{
    static void Main()
    {
        Console.WriteLine("Mag-ingat po tayong lahat");
        Circle myCircle = new Circle();

        // myCircle._radius = 10;
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myCircle2 = new Circle(100);

        Console.WriteLine(myCircle2.GetCircleArea());
    }



}