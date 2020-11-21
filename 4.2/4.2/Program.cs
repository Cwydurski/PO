using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] tab2 = new int[10];
            int[] tab1 = new int[10];
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj wartosc");
                tab1[i] = Convert.ToInt32(Console.ReadLine());

            }
            
            for (int i = 0; i < tab1.Length; i++)
            {
                
                if (tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                    

            }
                Console.WriteLine(tab2[i] + ",");
            }
            Console.ReadKey();
        }
    }
}


