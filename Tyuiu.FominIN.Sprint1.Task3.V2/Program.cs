﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint1.Task3.V2.Lib;

namespace Tyuiu.FominIN.Sprint1.Task3.V2
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
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, котрая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            double priceNotebook = 2;
            Console.WriteLine("Цена тетради = ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            int amountNotebook = 3;
            Console.WriteLine("Количество тетрадей = ");
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            double pricePencil = 2;
            Console.WriteLine("Цена ручки = ");
            pricePencil = Convert.ToDouble(Console.ReadLine());

            int amountPencil = 3;
            Console.WriteLine("Количество ручек = ");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Общая стоимость покупки = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));

            Console.ReadKey();
        }
    }
}
