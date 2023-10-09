using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint1.Task0.V4.Lib;

namespace Tyuiu.FominIN.Sprint1.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фомин И. Н. | ПКТб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                      *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #4                                                            *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                           *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, котрая вычисляет выражение 4/2*5/(3+2)*(5-2)      *");
            Console.WriteLine("* и печатает результат на экране.                                       *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* 4/2*5/(3+2)*(5-2)                                                     *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
