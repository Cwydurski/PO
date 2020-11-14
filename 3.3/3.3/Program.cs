using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Convert.ToInt32(Console.ReadLine());


            if (b > a && b > c)
            {
               Console.WriteLine("liczba b jest najwieksza");
               Console.ReadKey();
            }
                else 
                {
                    if(c > a && c > b)
                    {
                        Console.WriteLine("liczba c jest najwieksza");
                        Console.ReadKey();
                    }
                    else 
                    {
                        if(a > b && a > c)
                        {
                          
                         Console.WriteLine("liczba a jest najwieksza");
                         Console.ReadKey();
                        }
                        
                    }
                }
            
          
            Console.ReadKey();
        }
    }
}
