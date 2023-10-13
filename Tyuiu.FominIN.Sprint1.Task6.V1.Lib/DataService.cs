﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FominIN.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (value == ".")
            {
                return "";
            }
            else
            {
                char symbol = Convert.ToChar(value);
                int code = (int)symbol;
                return "Символ: " + symbol + " Код: " + code;
            }
        }
    }
}
