using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SedelnikovEA.Sprint2.Task4.V14.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            // Используем тернарный оператор согласно условию задачи
            double z = (x * 3 < Math.Sqrt(y) + 20)
                ? Math.Pow(2 + 1 / (x * x), y)
                : (y * y - Math.Pow(Math.Cos(x), 2) + 10) / (x * x - Math.Pow(Math.Sin(y), 2) + 12);

            return Math.Round(z, 3);
        }
    }
}