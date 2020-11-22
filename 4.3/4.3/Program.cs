using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ilosc elementow tablicy");
            int IloscIndexow = int.Parse(Console.ReadLine());
            int[] tablica = new int[IloscIndexow];
            int najmniejszy = 0;
            int najwiekszy = 0;
            double sredniaWszystkich = 0;
            int liczbaDodatnichElementow = 0;


            for (int x = 0; x < tablica.Length; x++)
            {
                Console.WriteLine("Wpisz wartosc do elementu tablicy oraz nacisnij 'enter'");
                tablica[x] = int.Parse(Console.ReadLine());

                if (najmniejszy > tablica[x])
                {
                    najmniejszy = tablica[x];
                }
                if (najwiekszy < tablica[x])
                {
                    najwiekszy = tablica[x];
                }
                if (tablica[x] > 0)
                {
                    liczbaDodatnichElementow++;
                }
                sredniaWszystkich += tablica[x];
            }
            int a = Array.IndexOf(tablica, najmniejszy);
            int b = Array.IndexOf(tablica, najwiekszy);
            sredniaWszystkich = sredniaWszystkich / tablica.Length;
            Console.WriteLine("\nNajmniejszy element wynosi: {0} wartość tego elementu znajduje się w indexie: {1} \nNajwiekszy element wynosi: {2} wartość tego elementu znajduje się w indexie: {3} \nLiczba dodatnich elementow wynosi: {4} \nSrednia wartosci wszystkich elementow wynosi: {5}", najmniejszy, a, najwiekszy, b, liczbaDodatnichElementow, sredniaWszystkich);
            Console.ReadKey();
        }
    }
}
