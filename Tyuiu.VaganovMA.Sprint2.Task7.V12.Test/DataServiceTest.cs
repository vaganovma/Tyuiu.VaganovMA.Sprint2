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

        double x = 1;
        double y = 2;

        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = false;

        Assert.AreEqual(wait, res);
        
    }
}