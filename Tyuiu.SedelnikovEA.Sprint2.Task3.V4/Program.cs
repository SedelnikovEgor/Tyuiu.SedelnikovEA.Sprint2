using Tyuiu.SedelnikovEA.Sprint2.Task3.V4.Lib;
using System;

namespace Tyuiu.SedelnikovEA.Sprint2.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Исходные данные:");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}