using System;

namespace PP_06_funkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Wartosc zmiennej przed wywolaniem funkcji: {0}",a);
            increment(ref a); //odwolujemy sie do danego adresu
            Console.WriteLine("Wartosc funkcji po wywolaniu funkcji : {0}", a);

            Console.ReadKey();

        }
        static void increment (ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x w wewnatrz funkcji {0}", x);
        }
    }
}
