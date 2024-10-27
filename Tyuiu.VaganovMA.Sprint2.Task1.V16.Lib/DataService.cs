namespace Tyuiu.VaganovMA.Sprint2.Task1.V16.Lib;
    using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task1V16
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] res = new bool[6];
        res[0] = a<b|c<d; //t
        res[1] = a>d&b>c;  //t
        res[2] = a!=c||b==d;  //t
        res[3] = b==d&&a==a;  //F
        res[4] = a!= c;  //t
        res[5] = (a >= c) ^ (c!=b);  //F
        return res;

    }
}

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
//последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив)
//(True, True, True, False, True, False), при a = 145, b = 716, c = 144, d = 137