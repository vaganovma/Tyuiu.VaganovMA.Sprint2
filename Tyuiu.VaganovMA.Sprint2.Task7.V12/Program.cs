using Tyuiu.VaganovMA.Sprint2.Task7.V12.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService(); 

        Console.Title = "Спринт #2 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #12                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        double x = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Введите переменную Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        if (res)
        {
            Console.WriteLine("Вошло");
        }
        else
        {
            Console.WriteLine("Точка невходит");
        }
        Console.ReadKey();
    } 
} 
