using System;

namespace Popova.Lab2.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            double A = 1.0 / 11.0 + 3.0 / Math.Exp(Math.Abs(y));
            double B = z / 3.0 + Math.Min(x, 2.0 * x);

            double f = A + B;

            Console.WriteLine($"f({x}, {y}, {z}) = {f}");
        }
    }
}
