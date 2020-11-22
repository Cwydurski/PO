using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[100];
            Random randomoweNaturalne = new Random();
            int kubelek = 2;

            for (int x = 0; x < tablica.Length; x++)
            {
                tablica[x] = randomoweNaturalne.Next(2, 1000);
                int liczba = tablica[x];

                for (int y = kubelek; y <= liczba; y++)
                {
                    if (liczba % liczba == 0 && liczba % 1 == 0)
                    {
                        if (liczba == 2)
                        {
                            Console.WriteLine("{0} to liczba pierwsza", liczba);
                            kubelek = 2;
                            break;
                        }
                        if (liczba % kubelek != 0)
                        {
                            if (liczba == kubelek + 1)
                            {
                                Console.WriteLine("{0} to liczba pierwsza", liczba);
                                kubelek = 2;
                                break;
                            }
                            else
                            {
                                kubelek++;
                            }
                        }
                        else
                        {
                            
                            kubelek = 2;
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
