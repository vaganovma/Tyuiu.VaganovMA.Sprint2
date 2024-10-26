namespace Tyuiu.VaganovMA.Sprint2.Task0.V26;

using Tyuiu.VaganovMA.Sprint2.Task0.V26.Lib;

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
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");

        int x = 1045;
        int y = 975;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        //Написать программу из операций сравнений (==, !=, <, >, <=, >=, 
        //последовательность операций не должна нарушаться) и арифметических выражений,
        //которая вернет логическую последовательность(массив):
        //(False, False, False, True, True, True), при x = 1045, y = 975
         
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X= "+x);
        Console.WriteLine("Y= "+y);
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();


    }
}
