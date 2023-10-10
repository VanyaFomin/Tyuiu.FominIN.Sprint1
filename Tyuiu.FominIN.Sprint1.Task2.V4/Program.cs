using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint1.Task2.V4.Lib;

namespace Tyuiu.FominIN.Sprint1.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фомин И. Н. | ПКТб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #4                                                                  *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, котрая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* вычислить площадь квадрата                                                   *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int x;

            Console.WriteLine("Длина стороны квадрата");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Площадь квадрата = " + ds.CalculateSquare(x));

            Console.ReadLine();
        }
    }
}
    

