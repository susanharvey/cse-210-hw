using System;

public class Fraction
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
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

//Getters and Setters were not necesary here. Could have used direct access.
    public int GetTopNUmber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

//Methods not member just local
    public string GetFractionString()
    {
        string fraction = $"{_topNumber}/{_bottomNumber}";

        return fraction;
    }

     public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
        //change int _topNumber to double by casting    
    }
}