using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FominIN.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Cos(y)) * Math.Tan(x * y);
            return res;
        }
    }
}
