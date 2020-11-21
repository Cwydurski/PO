using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tablica = new string[n];
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("Podaj wartosc");
                tablica[i] = Console.ReadLine();
                
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
