using System;
using Tyuiu.BelovolovVS.Sprint2.Task0.V6.Lib;

namespace Tyuiu.BelovolovVS.Sprint2.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 107;
            int y = 754;

            Console.Title = "Спринт #2 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SPRINT #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность (массив):                 *");
            Console.WriteLine("* (True, True, True, False, True, False), при x = 107, y = 754.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Размерность X = {x}");
            Console.WriteLine($"Размерность Y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetCompareOperations(x, y);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Результат операции #{i + 1}: {res[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
