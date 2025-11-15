class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        if (_radius < 0)
        {
            Console.WriteLine("Invalid Radius, must >= 0.0");
            _radius = 0;

        }
        else
        {
            _radius = radius;
        }

    }

    public double GetCircleArea()
    {
        return 3.145 * _radius * _radius;
    }
}