using System.Dynamic;
using System.Runtime.InteropServices;

public class Fraction
{


    // attributes
    private int _topNum;
    private int _bottomNum;


    // defining methods
    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNum)
    {
        _topNum = wholeNum;
        _bottomNum = 1;
    }

    public Fraction(int topNum, int botNum)
    {
        _topNum = topNum;
        _bottomNum = botNum;
    }


    // get methods (individual numbers)
    public int GetTop()
    {
        return _topNum;
    }

    public int GetBottom()
    {
        return _bottomNum;
    }



    // set methods 
    public void SetTop(int newTop)
    {
        _topNum = newTop;
    }

    public void SetBottom(int newBottom)
    {
       if (newBottom == 0)
        {
            _bottomNum = 1;
        }
        else
        {
            _bottomNum = newBottom;
        }
    }



    // get methods (full number)
    public string GetFraction()
    {
        return $"{_topNum}/{_bottomNum}";
    }

    public double GetDecimal()
    {
        return (double)_topNum / (double)_bottomNum;
    }


}