using System;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x0, delta;
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0) 
            {
                delta = Math.Sqrt(delta);
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
                Console.WriteLine("Są dwa pierwiastki rownania");
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else 
            {
                if (delta == 0) 
                {
                    x0 = -b / (2 * a);
                    Console.WriteLine("Jest jeden pierwiastek rownania");
                    Console.WriteLine(x0);

                }
                else 
                {
                    Console.WriteLine("brak pierwiastkow");
                }
            }
            Console.ReadKey();
        }

    }
}
