namespace Tyuiu.VaganovMA.Sprint2.Task4.V18;
using Tyuiu.VaganovMA.Sprint2.Task4.V18.Lib;

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
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");

        double x;
        double y;
        double z;

        Console.WriteLine("введите значение (x)");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение (y)");
        y = Convert.ToInt32(Console.ReadLine());

        double res = ds.Calculate(x,y);

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


        Console.WriteLine("Значение функции = " + res);


        Console.ReadKey();


    }
}