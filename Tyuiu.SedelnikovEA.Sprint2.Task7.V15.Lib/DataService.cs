using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SedelnikovEA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Вычисляем квадрат расстояния от начала координат до точки
            double distanceSq = x * x + y * y;

            // Проверяем, что y неотрицательный и точка лежит между окружностями радиусом 1 и 2
            if (y >= 0 && distanceSq >= 1 && distanceSq <= 4)
            {
                return true;
            }

            return false;
        }
    }
}
