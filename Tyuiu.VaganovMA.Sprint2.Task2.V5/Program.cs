namespace Tyuiu.VaganovMA.Sprint2.Task2.V5;

using Tyuiu.VaganovMA.Sprint2.Task2.V5.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Ваганов М А | ИИПБ-24-2";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые                                                           *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");

        int x;
        int y;      

        Console.WriteLine("введите значение (x)");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение (y)");
        y = Convert.ToInt32(Console.ReadLine());
        
        bool res = ds.CheckDotInShadedArea(x, y);

        //
        //
        //
        //

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X= " + x);
        Console.WriteLine("Y= " + y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (res)
        {
            Console.WriteLine("Точка входит в закрашенную часть");
        }
        else
        {
            Console.WriteLine("Точка не входит в закрашенную зону");
        }

        Console.ReadKey();


    }
}