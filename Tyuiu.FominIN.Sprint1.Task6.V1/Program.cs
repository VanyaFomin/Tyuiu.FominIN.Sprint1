using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint1.Task6.V1.Lib;

namespace Tyuiu.FominIN.Sprint1.Task6.V1
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
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, котрая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter>");
            Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Для завершения введите точку");

            string input = "";
            do
            {
                Console.Write("-> ");
                input = Console.ReadLine();
                string result = ds.SymbolCode(input);
                Console.WriteLine(result);
            } while (input != ".");
        }
    }
}
