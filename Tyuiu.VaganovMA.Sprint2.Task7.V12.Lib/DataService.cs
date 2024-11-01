namespace Tyuiu.VaganovMA.Sprint2.Task7.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V12
{
    public bool CheckDotInShadedArea(double x, double y)
    {       
        bool res;
        if ((x > 0 && y > 0 && x < 2 - x && x < Math.Pow(x, 2))
            || ( x < 0 && y > 0 && x < Math.Pow(x, 2) && x > x - 2))
        {
            res = true;
        }
        else
        {
            res = false;
        }
        return res;
    }
}

