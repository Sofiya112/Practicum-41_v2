using System;
using System.Linq;

namespace Practicum_41_v2
{
    class Program
    {
        static double GetMin(double a, double b) //Минимальное число
        {
            return new double[] { a, b }.Min();
        }

        static double GetMax(double a, double b) //Максимальное число
        {
            return new double[] { a, b }.Max();
        }

        delegate double CompareDelegate(double x, double y);

        static void Main(string[] args)
        {
            CompareDelegate compare = GetMin;

            double a = 5.6, b = 3.4;
            Console.WriteLine($"Наименьшее число между {a} и {b}: {compare(a, b)}");

            compare = GetMax;
            Console.WriteLine($"Наибольшее число между {a} и {b}: {compare(a, b)}");

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine(); 
        }
    }
}
