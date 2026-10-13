using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SedelnikovEA.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            string[] area =
            {
        "...............",
        "...............", 
        "..###...####...",
        "..###...####...", 
        "..##########...",
        "..###########..",
        "..###########..",
        "...#.########..",
        "...#.####......",
        "...#...##......",
        "..###..##......",
        "...#...##......", 
        "...#...........", 
        ".#####.........", 
        "...............", 
            };

            if (x >= 1 && x <= 15 && y >= 1 && y <= 15)
            {
                res = area[y - 1][x - 1] == '#';
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}