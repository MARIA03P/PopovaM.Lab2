using System;

namespace Popova.Lab2.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввежите переменную");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            double A = 1.0 / 11.0 + 3.0 / Math.Exp(Math.Abs(x));
            double B = x / 3.0 + Math.Min(x, 2.0 * x);
            double C = 3.0 * x * Math.Sin(1.0 / 3.0) + Math.Pow(x, (x - 1.0) / 2.0);
            double f = A + B + C;

            Console.WriteLine($"f({x}) = {f}");
        }
    }
}
