using System;

namespace PP03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program ktory za pomoca instrukcji do...while
             * dla danych wartosci zmieniajacych sie w przedziale od 0 do 15
             * obliczy wartosc funkcji y = 4x  */
            int x=0, y;
            do
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}",x,y);
                x++;
            } while (x <= 15);

            //TABLICZKA MNOŻENIA
            int a = 1, b = 1, c;
            do
            {
                do
                {
                    c = a * b;
                    Console.Write(c +"\t");
                    b++;
                } while (b<=10);
                b = 1;
                Console.WriteLine("");
                a++;
            } while (a<=10);


            /*Napisz program ktory za pomoca instrukcji while
            dla danych wartosci x zmieniajacych sie w przedziale od 1 do 50
            obliczy ich sume */
            int d=1, suma=0;
            while (d<=50)
            {
                suma += d;
                d++;
            }
            Console.WriteLine("\n1. Suma wynosi: {0}", suma);

            /* Napisz program, ktory za pomoca petli for zsumuje liczby nieprzyste
             * z przedzialu od 1 do 10; */
            suma = 0;
            for(int i=0; i<=10; i++)
            {
                if(i%2==1)
                {
                    suma += i;
                }
            }
            Console.WriteLine("\n2. Suma wynosi: {0}", suma);

            /*ZADANIE 1
            float wynik;
            Console.WriteLine("Podaj a: ");
            float j = Console.ReadLine(j);
            Console.WriteLine("Podaj b: ");
            float k = Console.ReadLine(k);
            if (a + b != 0)
            { 
                wynik = ((j * j) + k) / ((j + k) * (j + k));
                Console.WriteLine("Wynik: {0}", wynik);
            }
            else
            {
                Console.WriteLine("BLAD! Dzielenie przez 0");
            }*/

            /* Napisz program ktory wyswietli duze litery alfabetu
             * od A do Z i od Z do A z wykorzystaniem petli for 
             * np. A, B, C,..., Z.
             * np. Z, Y, X,..., A.
             */

            for(char znak = 'A'; znak<='Z'; znak++)
            {
                if (znak != 'Z') Console.Write(znak + ",");
                else Console.Write(znak + ".");
            }
   
            for (char znak1 = 'Z'; znak1 <= 'A'; znak1--)
            {
                if (znak1 != 'A') Console.Write(znak1 + ",");
                else Console.Write(znak1 + ".");
            }

            //continue
            Console.WriteLine("");
            int j = 1;
            for(;j<=10;j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    continue;
                else Console.Write("{0} ", j);
            }


            //brake
            Console.WriteLine("");
            int t = 1;
            for (; j <= 10; j++)
            {
                if (t == 2 || t == 5 || t == 7)
                    break;
                else Console.Write("{0} ", j);
            }





        }
    }
}
