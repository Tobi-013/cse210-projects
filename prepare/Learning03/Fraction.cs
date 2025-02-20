public class Fraction
{
    private int  _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int Wholenumber)
    {
        _top = Wholenumber;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public int GetNumerator()
    {
        return _top;
    }
    public int GetDenominator()
    {
        return _bottom;
    }
    public void SetNumerator(int top)
    {
        _top = top;
    }
    public void SetDenominator(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {   
       
        string FractionAsString = $"{_top}/{_bottom}";

        return FractionAsString;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}