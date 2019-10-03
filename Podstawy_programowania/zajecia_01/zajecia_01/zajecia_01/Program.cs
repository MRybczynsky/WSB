using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz

            /*komenatrz
             * w
             * wileu liniach
             */

            Console.WriteLine("Janusz");


            //zmienne i typy danych
            int x = 10;
            x = 15;
            Console.WriteLine(x);

            int x1, y = 10, z = 15;
            x1 = 2;

            Console.WriteLine("Zmienna x1 wynosi: ");
            Console.WriteLine(x1);
            //konkatenacja
            Console.WriteLine("y = " + y + "\nz = " + z);

            /*int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);*/

            //alternatywny sposob deklaraji zmiennych
            //int c = 0;

            //int c = new int(); //wartsoc domyslna ==> null (brak referencji)




            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Twoje imie wprowadzone z klawiatury: " + name);

            /*int z1 = 12;
            uint z2 = 20;
            double y1 = 10.55F;
            Console.WriteLine("zmienna y1 = " + y1);*/

            //obl pole prostokata, wprowadz dane z klawiatury
            Console.WriteLine("Podaj wymiary prostokąta: ");
            Console.WriteLine("Podaj bok A: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok B: ");
            double y = double.Parse(Console.ReadLine());
            double result = x * y;
            Console.WriteLine("Wynik: " + result);

            Console.ReadKey();
        }
    }
}
