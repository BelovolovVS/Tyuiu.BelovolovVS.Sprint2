namespace Tyuiu.BelovolovVS.Sprint2.Task2.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task2V7
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        bool res;

        if ((x >= 3 && x <= 6 && y >= 3 && y <= 11) ||
            (x >= 4 && x <= 6 && y == 12) ||
            (x >= 4 && x <= 5 && y == 13) ||
            (x >= 7 && x <= 8 && y >= 5 && y <= 7) ||
            (x >= 9 && x <= 12 && y >= 3 && y <= 10) ||
            (x == 13 && y >= 6 && y <= 7) ||
            (x >= 10 && x <= 12 && y == 11) ||
            (x == 11 && y == 12))
        {
            res = true;
        }
        else
        {
            res = false;
        }

        return res;
    }

}