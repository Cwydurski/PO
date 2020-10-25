using System;

namespace ConsoleApp3
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int x;
            x = 5;
            Console.WriteLine(x);
            Console.ReadKey();
        }*/
        /*static void Main(string[] args)
        {
            int a, b, wynik;
            a = 4;
            b = 1;
            wynik = 2 * a - 3 * b;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }*/
        /* static void Main(string[] args)
         {
             double F, C;
             Console.WriteLine("Podaj temp. w stopniach Fahrenheita");
             F = double.Parse(Console.ReadLine());
             C = 5.0 / 9 * (F - 32);
             Console.WriteLine(C);
             Console.ReadKey();
         }*/
        /*static void Main(string[] args)
        {
            const int komputery = 24;
            int studenci;
            double wynik;
            Console.WriteLine("Podaj liczbę studentów: ");
            studenci = Convert.ToInt32(Console.ReadLine());
            wynik = (double)studenci / komputery;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }*/
        /*static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Podaj x (większe od 0): ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            Console.WriteLine(y);
            Console.ReadKey();
        }*/
        /*static void Main(string[] args)
        {
            int x = 0, y;
            y = x++ * 2;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }*/
        /*static void Main(string[] args)
        {
            int x, y = 4;
            x = (y += 3);
            x = ++y;
            x = y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }*/
        /*static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y;
            x = y++;
            x = --y;
            x = y--;
            Console.WriteLine(y++);
            Console.ReadKey();
        }*/
        static void Main(string[] args)
        {
            double wiek, PLN;
            bool kino;
            Console.WriteLine("Podaj wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20);
            Console.WriteLine(kino);
            Console.ReadKey();
        }



    }
}
