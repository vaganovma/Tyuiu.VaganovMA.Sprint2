
using Tyuiu.VaganovMA.Sprint2.Task3.V26.Lib;

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
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #26                                                              *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");

        double x;
        
        Console.WriteLine("введите значение (x)");
        x = Convert.ToInt32(Console.ReadLine());
        
        double res = ds.Calculate(x);

        //
        //
        //
        //

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

       
            Console.WriteLine("Значение функции = "+res);
        

        Console.ReadKey();


    }
}