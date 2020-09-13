/*УТС-22, Припотнев Михаил, ДЗ_1*/
using System;

namespace Homework
{
    using static Math;
    using static Console;
    public static class Homework1
    {
        public static double y(double x)
        {
            return 3 * Pow(x, 6) - 6 * Pow(x, 2) - 7;
        }

        public static void Main()
        {
            Write("Введите действительное число: ");
            double x = double.Parse(ReadLine());
            WriteLine($"y = 3*x^6 - 2*x^2 - 7 = {Round(3 * Pow(x, 6), 3)} - {Round(3 * Pow(x, 2), 3)} - 7 = {Round(y(x), 3)}");
        }
    }
}