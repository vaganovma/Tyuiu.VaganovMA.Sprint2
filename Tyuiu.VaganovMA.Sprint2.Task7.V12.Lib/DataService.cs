namespace Tyuiu.VaganovMA.Sprint2.Task7.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V12
{
    public bool CheckDotInShadedArea(double x, double y)
    {       
        bool res;
        double z1 = Math.Pow(x, 2);
        double z2 = x - 2;

        if ((x > 0 && y > 0 && y <= z2 && y <=z1)
            || ( x < 0 && y > 0 && y <= z1 && y>=z2))
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

