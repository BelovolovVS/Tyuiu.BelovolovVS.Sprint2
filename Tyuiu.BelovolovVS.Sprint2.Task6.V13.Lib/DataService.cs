using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelovolovVS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29,
                _ => throw new ArgumentException("Некорректный месяц")
            };

            n++;

            if (n > daysInMonth)
            {
                n = 1;
                m++;

                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }

            string dayStr = n < 10 ? "0" + n : n.ToString();
            string monthStr = m < 10 ? "0" + m : m.ToString();

            return $"{dayStr}.{monthStr}.{g}";
        }
    }
}