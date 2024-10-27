namespace Tyuiu.VaganovMA.Sprint2.Task2.V5.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task2.V5.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
//последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив)
//(True, True, True, False, True, False), при a = 145, b = 716, c = 144, d = 137

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GeLogicOperations()
    {
        DataService ds = new DataService();
        int x = 6;
        int y = 7;
                
        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        Assert.AreEqual(wait, res);
    }
}