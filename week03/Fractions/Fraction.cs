using System;
using System.Reflection.Metadata.Ecma335;

class Fraction
{
    private int _top;
    private int _bottom;

    /// <summary>
    /// Construct a new Fraction with numerator and denominator set to 1.
    /// </summary>
    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
    }

    /// <summary>
    /// Construct a new Fraction with numerator set to the given value and denominator set to 1.
    /// </summary>
    /// <param name="wholeNumber">The numerator of the fraction.</param>
    public Fraction(int wholeNumber) 
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    /// <summary>
    /// Construct a new Fraction with the given numerator and denominator.
    /// </summary>
    /// <param name="top">The numerator of the fraction.</param>
    /// <param name="bottom">The denominator of the fraction.</param>
    public Fraction(int top, int bottom) 
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() 
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue() 
    {
        double fractionDecimal = (double)_top / (double)_bottom;
        return fractionDecimal;
    }

}