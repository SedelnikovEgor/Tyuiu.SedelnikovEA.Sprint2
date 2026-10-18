using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SedelnikovEA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int k)
        {
            string res;

            // Используем оператор switch согласно условию задачи
            switch (k)
            {
                case 6: res = "шестерка"; break;
                case 7: res = "семерка"; break;
                case 8: res = "восьмерка"; break;
                case 9: res = "девятка"; break;
                case 10: res = "десятка"; break;
                case 11: res = "валет"; break;
                case 12: res = "дама"; break;
                case 13: res = "король"; break;
                case 14: res = "туз"; break;
                default: throw new ArgumentException("Номер карты должен быть от 6 до 14.");
            }

            return res;
        }
    }
}
