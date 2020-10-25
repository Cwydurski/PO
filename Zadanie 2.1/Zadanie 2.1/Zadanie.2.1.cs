using System;

namespace Zadanie_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temperature w stopniach Celciusza");
            C = double.Parse(Console.ReadLine());
            F = 32 + 9.0 / 5 * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}

