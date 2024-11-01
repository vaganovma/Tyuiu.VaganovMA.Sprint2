namespace Tyuiu.VaganovMA.Sprint2.Task7.V12.Test;

using System;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task7.V12.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();

        double x = 0.1;
        double y = 0;

        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;

        Assert.AreEqual(wait, res);
        
    }
}