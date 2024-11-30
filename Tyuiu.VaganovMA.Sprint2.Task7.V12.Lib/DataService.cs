namespace Tyuiu.VaganovMA.Sprint2.Task7.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V12
{
    public bool CheckDotInShadedArea(double x, double y)
    {       
        bool res;
        double z1 = Math.Pow(x, 2);
        //double z2 = x - 2;

        if ((x > 0 && y <= 2-x)
            || ( x < 0 && y <= z1))
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
int a = 2
int b = 4
int c = 3
int d = 5
        
for(int i = 1; i<5; i++)
{
c++;
c+=b;
a=b+c;
d=(a-b)+i
}       
Console.WriteLine(d);
