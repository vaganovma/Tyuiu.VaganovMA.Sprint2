namespace Tyuiu.VaganovMA.Sprint2.Task1.V16.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint2.Task1.V16.Lib;

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