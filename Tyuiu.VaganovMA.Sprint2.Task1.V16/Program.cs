namespace Tyuiu.VaganovMA.Sprint2.Task1.V16;

using Tyuiu.VaganovMA.Sprint2.Task1.V16.Lib;

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
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");

        int a = 145;
        int b = 716;
        int c = 144;
        int d = 137;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        

        //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
        //но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
        //последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив)
        //(True, True, True, False, True, False), при a = 145, b = 716, c = 144, d = 137

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("a= " + a);
        Console.WriteLine("b= " + b);
        Console.WriteLine("c= " + c);
        Console.WriteLine("d= " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();


    }
}
