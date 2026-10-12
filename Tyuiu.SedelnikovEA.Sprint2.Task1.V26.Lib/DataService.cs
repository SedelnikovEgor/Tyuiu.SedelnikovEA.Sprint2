using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SedelnikovEA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + b == 1325) | false;
            res[1] = (c != d) & true;
            res[2] = (a < b) || false;
            res[3] = (a > b) && true;
            res[4] = a - d <= b;
            res[5] = a - d >= b;

            return res;
        }
    }
}