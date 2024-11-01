namespace Tyuiu.VaganovMA.Sprint2.Task5.V5;

using Tyuiu.VaganovMA.Sprint2.Task5.V5.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Ваганов М А | ИИПБ-24-2";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые                                                           *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                            *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n;
        
        Console.WriteLine("введите номер от 6 до 14 (n)");
        n = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((n < 6) || (n > 14)) 
        {
            res = "не то";
        }
        else
        {
            res = n+" = "+ds.FindCardValue(n);
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine(res);
        Console.ReadKey();


    }
}