using System;

namespace Popova.Lab2.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double sq = A * B;
            double pirimetr = 2 * (A + B);
            double gip = Math.Sqrt(A * A + B * B);
            Console.WriteLine($" Square of the shape = {A * B}, pirimert of the shape {2 * (A + B)}, diagonal is {gip}");
        }
    }
}
