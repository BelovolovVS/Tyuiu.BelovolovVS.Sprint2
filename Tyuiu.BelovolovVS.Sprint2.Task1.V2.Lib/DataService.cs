using System.Diagnostics;

namespace Tyuiu.BelovolovVS.Sprint2.Task1.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task1V2
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] res = new bool[6];
        res[0] = (d - 20 == c) | (d < c);
        res[1] = (b > a) & (c != d);
        res[2] = (a + 21 == b) || (d == c);
        res[3] = (b > c) && (d > a);
        res[4] = !(a > b);
        res[5] = (a == b) ^ (c > d);
        return res;
    }
}
