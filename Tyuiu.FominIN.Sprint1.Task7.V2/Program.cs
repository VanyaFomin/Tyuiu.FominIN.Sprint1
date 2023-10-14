using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint1.Task7.V2.Lib;

namespace Tyuiu.FominIN.Sprint1.Task7.V2
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
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("*     sin(x) + cos(y)                                                          *");
            Console.WriteLine("* z = --------------- tg xy                                                    *");
            Console.WriteLine("*     cos(y) - sin(y)                                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y).ToString("F3"));

            Console.ReadKey();
        }
    }
}
