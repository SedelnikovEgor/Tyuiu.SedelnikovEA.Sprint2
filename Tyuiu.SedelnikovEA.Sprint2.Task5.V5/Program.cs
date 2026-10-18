using System;
using Tyuiu.SedelnikovEA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите порядковый номер карты k (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res = ds.FindCardValue(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Достоинство карты: " + res);
            Console.ReadLine();
        }
    }
}
