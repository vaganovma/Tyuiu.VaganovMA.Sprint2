namespace Tyuiu.VaganovMA.Sprint2.Task4.V18.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task4.V18.Lib;

//

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = -1;
        double y = 2;      
        double res = ds.Calculate(x,y);
        double wait = 0.174;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 0;
        double res = ds.Calculate(x,y);
        double wait = 0;
        Assert.AreEqual(wait, res);
    }
    
}