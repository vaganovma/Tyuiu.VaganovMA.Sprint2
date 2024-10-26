namespace Tyuiu.VaganovMA.Sprint2.Task0.V26.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task0V26
{
    //Написать программу из операций сравнений (==, !=, <, >, <=, >=, 
    //последовательность операций не должна нарушаться) и арифметических выражений,
    //которая вернет логическую последовательность(массив):
    //(False, False, False, True, True, True), при x = 1045, y = 975

    public bool[] GetCompareOperations(int x, int y)
    {       
            bool[] res = new bool[6];
            res[0] = x==y; //False
            res[1] = x!=y+70;  //False
            res[2] = x<y;  //False
            res[3] = x>y;  //True
            res[4] = y<=x;  //True
            res[5] = x>=y;  //True

        return res;        
    }
}

