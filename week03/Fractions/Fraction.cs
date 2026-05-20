using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Fraction
{
    private int _top;
    private int _bottom;
    
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;

    }
    
    public int GetBottom()
    {
        return  _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        _top = 1;
        _bottom = 1;
        return $"{_top} / {_bottom}.";
    }
    public string GetFractionString(int top, int bottom)
    {   
        _top = top;
        _bottom = bottom;
        return $"{_top} / {_bottom}.";
    }
    public string GetFractionString(int top)
    {
        _top = top;
        _bottom = 1;
        return $"{_top} / {_bottom}.";
    }
    public double GetDecimalValue(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        return (double)_top / _bottom;
    }
    public double GetDecimalValue(int top)
    {
        _top = top;
        _bottom = 1;
        return (double)_top / _bottom;
    }
    public double GetDecimalValue()
    {
        _top = 1;
        _bottom = 1;
        return (double)_top / _bottom;
    }

}