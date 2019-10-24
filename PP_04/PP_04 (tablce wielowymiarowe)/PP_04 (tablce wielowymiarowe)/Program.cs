using System;

namespace PP_04__tablce_wielowymiarowe_
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 0, j = 0;
            int[,] values = new int[,]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };
            for (i = 0; i < values.GetLength(0); i++) //pobierana ilosc wierszy
            {
                for (j = 0; j < values.GetLength(1); j++) // pobierana ilosc kolumn
                {
                    Console.Write("{0}\t", values[i, j]);
                }
                Console.WriteLine("");
            }



            // wypelnianie tablcy 

            j = 0;
            int[,] tab = new int[3, 3];
            for (i = 0; i < tab.GetLength(0); i++)
            {
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = i * 3 + j;
                }
            }
            Console.WriteLine("");

            for (i = 0; i < tab.GetLength(0); i++)
            {
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0}\t", tab[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
