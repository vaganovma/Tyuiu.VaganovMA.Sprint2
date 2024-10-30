namespace Tyuiu.VaganovMA.Sprint2.Task3.V26.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task3.V26.Lib;

//

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = 1;
        double res = ds.Calculate(x);
        double wait = 3.001;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 0;
        double res = ds.Calculate(x);
        double wait = 1.667;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition3()
    {
        DataService ds = new DataService();
        double x = -1;
        double res = ds.Calculate(x);
        double wait = -229.195;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition4()
    {
        DataService ds = new DataService();
        double x = -31;
        double res = ds.Calculate(x);
        double wait = -247.968;
        Assert.AreEqual(wait, res);
    }

}