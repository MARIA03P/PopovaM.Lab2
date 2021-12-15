using System;

namespace Popova.Lab2.Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" My Country : ");
            double sq = 17130000;
            string name = "Russia";
            int peop = 150000000;
            int lakes = 98;
            int mountains = 71;
            double pdensity = Math.Round(peop / sq,4) ;
            
            Console.WriteLine($"Name = {name}, square = {sq} km^2, population {peop} people, lakes {lakes}, mountains = {mountains}, population density= {pdensity} people/km^2");
            
        }
    }
}
