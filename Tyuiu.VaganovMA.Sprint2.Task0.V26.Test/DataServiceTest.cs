namespace Tyuiu.VaganovMA.Sprint2.Task0.V26.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task0.V26.Lib;

//Ќаписать программу из операций сравнений (==, !=, <, >, <=, >=, 
//последовательность операций не должна нарушатьс€) и арифметических выражений,
//котора€ вернет логическую последовательность(массив):
//(False, False, False, True, True, True), при x = 1045, y = 975

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GetCompareOperations()
    {
        DataService ds = new DataService();
        int x = 1045;
        int y = 975;        
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x,y);
        bool[] wait = new bool[6] {false, false, false, true, true, true };
        CollectionAssert.AreEqual(wait, res);
    }
}