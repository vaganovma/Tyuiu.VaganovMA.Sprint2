namespace Tyuiu.VaganovMA.Sprint2.Task1.V16.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task1.V16.Lib;

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
        int a = 145;
        int b = 716;
        int c = 144;
        int d = 137;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        bool[] wait = new bool[6] { true, true, true, false, true, false };
        CollectionAssert.AreEqual(wait, res);
    }
}