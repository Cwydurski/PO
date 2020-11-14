using System;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, silnia = 1;
                Console.WriteLine("Podaj n");
           n=Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("n nie moze byc mniejsze od 0");
            else
            {
                if (i >= n)
                    Console.WriteLine(silnia);

                else if (i < n)
                {
                    while (i < n)
                    {
                        i++;
                        silnia *= i;

                    }
                    Console.WriteLine("silnia wynosi:");
                    Console.WriteLine(silnia);
                }
            }
            Console.ReadKey();

        }
    }
}
