using System;

namespace PP03_tab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program ktory 10 elemetowej tablicy jednowymiarowej
             * o nazwie tab umieszcza liczby clakowite z przedzialu od 1 do 10*/
             int n= 10, i;
            //deklaracja tablicy o nazwie tab typu calkowitego o roziarze n=10
            int[] tab = new int[n];
            for(i=0; i<tab.Length; i++)
            {
                tab[i] = i;
            }
            //wyswietlenie zwartosci tablicy
            for (i = 0; i < tab.Length; i++)
            {
               Console.WriteLine("{0} ", tab[i]); 
            }

            /* Napisz programktory w 5elementowej tablicy o nazwie colours
             * umieszcza nazwy kolorow podane z klawiatury(for)
             * Wyswietl kolory w formacie(while):
             * kolor1 : red
             * kolor2 : blue
             * ...
             * kolor5 : yellow
             */
            int t = 5, j;
            string [] colours = new string[t];
            string color;
            for (j = 0; j < colours.Length; j++)
            {
                Console.WriteLine("Kolor {0} ", j+1, ": ");
                color = Console.ReadLine();
                colours[j] = color;
            }
            //wyswietlenie zwartosci tablicy
            while( j < colours.Length )
            {
                Console.WriteLine("Kolor {0} ", j + 1, ": {1}", colours[j]);
                j++;
            }

        }
    }
}
