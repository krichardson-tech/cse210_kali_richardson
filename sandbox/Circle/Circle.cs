class Circle
{
    private double _radius; //attribute = radius

    public Circle() //constructor (default)
    {
        _radius = 1.0;
    }

    public Circle(double radius) //constructor (non-default)
    {
        SetRadius(radius);
    }

    public Circle(int radius) //constructor (non-default)
    {
        SetRadius(radius);
    }

    public double GetArea() // method = GetArea
    {
        return 3.14159 * _radius * _radius;
    }

    private void SetRadius(double radius) // set stuff useally public
    {
        if (radius < 0)
        {
            _radius = 1.0;
            Console.WriteLine("Invalid value, must be >- 0");
        }
        else
        {
            _radius = radius;
        }
    }
}