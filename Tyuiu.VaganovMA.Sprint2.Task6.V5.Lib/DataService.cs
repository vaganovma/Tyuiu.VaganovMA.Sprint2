namespace Tyuiu.VaganovMA.Sprint2.Task6.V5.Lib;

using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task6V5
{
    public string FindCardValue(int value)
    {        
        switch (value)
        {
            case 6: return "�������� ";
            case 7: return "������� ";
            case 8: return "���������";
            case 9: return "������� ";
            case 10: return "������� ";
            case 11: return "����� ";
            case 12: return "����";
            case 13: return "������ ";
            case 14: return "��� ";
            default: throw new ArgumentException("������������ ������"); ;
        }
        
    }
}