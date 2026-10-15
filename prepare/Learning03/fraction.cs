class Fraction
{
    
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        setTopNumber(topNumber);
        setBottomNumber(1);
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        setTopNumber(topNumber);
        setBottomNumber(bottomNumber);
    }

    public void setTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }
    public int getTopNumber()
    {
        return _topNumber;
    }

    public void setBottomNumber(int bottomNumber)
    {
        if (bottomNumber !=0)
        {
            _bottomNumber = bottomNumber;
        }
        else
        {
            _bottomNumber = 1;
        }
    }

        public int getBottomNumber()
    {
        return _bottomNumber;
    }

    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDeciamlValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}