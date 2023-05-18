using System;

class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    public int GetTop()
    {
        int top = _top;
        return top;
    }

    public int GetBottom()
    {
        int bottom = _bottom;
        return bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {
        string fractionString = String.Format("{0}/{1}", GetTop(), GetBottom());
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = Convert.ToDouble(GetTop())/ Convert.ToDouble(GetBottom());
        return decimalValue;
    }

}