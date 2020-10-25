using System;

namespace Zad._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,delta;
            Console.WriteLine("Podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (b * b) - 4 * (a * c);
             Console.WriteLine(delta);
            Console.ReadKey();
                
        }
    }
}
