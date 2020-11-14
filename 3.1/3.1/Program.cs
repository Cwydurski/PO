using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ROK;
            Console.WriteLine("Podaj rok");
            ROK = Convert.ToInt32(Console.ReadLine());
            if ((ROK % 4 == 0 && ROK % 100 != 0) || (ROK % 400 == 0))
                Console.WriteLine("Rok jest przestepny");
            else
                Console.WriteLine("Rok nie jest przestepny");
            Console.ReadKey();

        }
    }
}
