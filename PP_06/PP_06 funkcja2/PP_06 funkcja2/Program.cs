using System;

namespace PP_06_funkcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program ktory wyswietli czy liczba jest parzysta czy nieparzysta
             * Funkcja zwraca string  (liczba parzysta/liczb nieparzysta)
             * 
             */
            Console.WriteLine("Liczba jest {0} ", Para(10));
            /* Napisz funkcje ktora wyswietlisume cyfr w liczbie
             * 
             */
            Console.WriteLine(Sum(1235));
        }

        static string Para(int a)
        {
            if (a % 2 == 0) return "parzysta";
            else return "nieparzysta";
        }
        static int Sum(int x, int sum = 0)
        {
            do
            {
                sum = sum + x % 10;
                x /= 10;
            } while (x != 0);
            return sum;
        }
    }
}
