using System;
using Tyuiu.SedelnikovEA.Sprint2.Task0.V1.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task0.V1
{
    class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 233;
            int y = 122;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("************************************************");

            Console.WriteLine("x = 233");
            Console.WriteLine("y = 122");

            Console.WriteLine("************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}