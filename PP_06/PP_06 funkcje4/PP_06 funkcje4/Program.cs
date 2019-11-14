using System;

namespace PP_06_funkcje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            increment(out a); //odwolujemy sie do danego adresu
            Console.WriteLine("Wartosc funkcji po wywolaniu funkcji : {0}", a);

            Console.ReadKey();

        }
        static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("Zmienna x w wewnatrz funkcji {0}", x);
        }
    }
}
