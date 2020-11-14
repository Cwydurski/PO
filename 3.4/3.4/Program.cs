using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,wynik=0;
            string znak;
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj znak");
            znak = Console.ReadLine();
          
            switch (znak)
            { 
                case "+": 
                    wynik = a + b;
                    break;
                case "-": 
                    wynik = a - b;
                    break;
                case "*": 
                    wynik = a * b;
                    break;
                case "/": 
                    wynik = a / b;
                    break;
                default: 
                    Console.WriteLine("Podano zły symbol");
                    break; 
            }
            Console.WriteLine(wynik);
            Console.ReadKey();
        }

    }
}
