namespace Tyuiu.VaganovMA.Sprint2.Task2.V5.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task2.V5.Lib;

//�������� ��������� �� �������� ��������� (==, !=, <, >, <=, >=, ������������������ ����� ����������,
//�� ������������ ���� ��� � ���������) � ���������� �������� (|, &, ||, &&, !, ^, 
//������������������ �������� �� ������ ����������), � ����� �������������� ���������, ������� ������ ���������� ������������������(������)
//(True, True, True, False, True, False), ��� a = 145, b = 716, c = 144, d = 137

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