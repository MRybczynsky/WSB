using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_05_wyjatki_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while(true)
            {
                Console.WriteLine("Wprowadz liczbe calkowita");
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    Console.WriteLine("Zakres liczb: <0; 4 294 967 295\n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartosc nie może być pusta");
                }
                Console.WriteLine("Wprowadz poprawnie wartosc");
            }

            Console.WriteLine("\nLiczba calkowita: {0}", number);
            Console.ReadKey();
        }
    }
}
