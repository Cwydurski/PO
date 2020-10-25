using System;

namespace zad._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int masa;
            int wzrost;
            double bmi,wynik;
            Console.WriteLine("Podaj masę");
            masa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wzrost");
            wzrost = Convert.ToInt32(Console.ReadLine());
            bmi = masa / (Math.Pow(wzrost,2));
            Console.WriteLine(bmi);
            wynik = Math.Round(bmi,4);
            Console.WriteLine(wynik);
          
            Console.ReadKey();
        }
    }
}
