using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_05_tab
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ 
            int a = 10;
            int b = a;

            a--;
            b++;


            Console.WriteLine("");
            //typ referencyjny

            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
            
            tabA[2] = 10;
            tabB[0] = 8;

            Console.WriteLine("Wyswietlanie tablicy A");
            foreach(int item in  tabA)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\nWyswietlanie tablicy B");
            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            
            // kopiowanie tablic
            
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach(int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            tab.CopyTo(tabCopy, 0);
            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            //kopiowanie tablic 2 
            Console.WriteLine("sdf");
            //Array.Copy(tab, tabCopy, tab.Length);
            int[] tabCopy2 = new int[5];
            Array.Copy(tab, tabCopy2, 3);
            foreach (int item in tabCopy2)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
