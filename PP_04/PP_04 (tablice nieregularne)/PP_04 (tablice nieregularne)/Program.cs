using System;

namespace PP_04__tablice_nieregularne_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j= 0;
            int[][] number = new int[3][]
            {
                new int[] {1,2},
                new int[] {3,4,5,6},
                new int[] {7}
            };

            for(i=0; i<number.GetLength(0); i++)
            {
                for(j=0;j<number[i].Length;j++)
                {
                    Console.WriteLine("Number[{0},{1}] = {2}", i, j, number[i][j]);
                }
                Console.WriteLine("");
            }

            // uproszczone wyrazenia inicjalizacji tablic

            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            Console.WriteLine(vowels[0]);

            byte[,] age =
            {
                {20,30},
                {15,35},
                {25,35}
            };
            Console.WriteLine(age[2,0]);

            string[][] name =
            {
                new string [] {"Katarzyna"},
                new string [] {"Krzysztof", "Anna"},
                new string [] {"Pawel"}
            };
            Console.WriteLine(name[1][1]);

            // ilosc wymiarow

            Console.WriteLine("Samogloski - {0}", vowels.Rank);
            Console.WriteLine("Wiek - {0}", age.Rank);
            Console.WriteLine("Imiona - {0} ", name.Rank);

            /* Zapisz w tablicy tlumaczenia slow:
             * 1 Poniedzialek monday
             * 2 Wtorek tuesday
             * itd.
             * 
             * Użytkownik wprowadza z klawiatury polskie slowo i angileskie tlumaczenie
             */
            Console.WriteLine("DNI TYGODNIA PO POLSKU I ANGIELSKU");
            string[,] weekDays = new string[7,2];
            string [] day = { "pierwszy", "drugi", "trzeci", "czwarty", "piąty", "szósty", "siódmy" };
            string word;

            j = 0;
            for(i=0;i<weekDays.GetLength(0);i++)
            {
                for (j = 0; j < weekDays.GetLength(1); j++)
                {
                    if(j==0)
                    {
                        Console.WriteLine("Podaj {0} dzien tygodnia w jezyku polskim: ", day[i]);
                    }
                    else
                    {
                        Console.WriteLine("Podaj {0} dzien tygodnia w jezyku angielskim: ", day[i]);
                    }
                    word = Console.ReadLine();
                    weekDays[i, j] = word;
                }
                Console.WriteLine();
            }

            byte count = 1;
            Console.WriteLine("Lp. \tpolski\tangielski");
            Console.ReadKey();
        }
    }
}
