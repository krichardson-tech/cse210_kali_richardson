class Circle
{
    private double _radius; //attribute = radius

    public double GetArea() // method = GetArea
    {
        return 3.14159 * _radius * _radius;
    }

    public void SetRadius(double radius)
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