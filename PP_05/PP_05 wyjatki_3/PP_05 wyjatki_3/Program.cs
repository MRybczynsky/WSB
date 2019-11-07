using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_05_wyjatki_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                uint x = 10;
                try
                {
                    Console.WriteLine("Podaj dzien tygodnia (1-5): ");
                    string str = Console.ReadLine();
                    x = uint.Parse(str);
                }
                catch
                {
                    Console.WriteLine("ERROR!!!");
                }
                finally
                {
                    Console.WriteLine("x = {0}", x);
                }
            

            //###################################################################

            switch(x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new System.Exception("Masz juz weekend, bledne dane");
                    break;
                case 7:
                    throw new System.Exception("Masz juz weekend, niedziela");
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException("Bledny zakres");
                    break;

            }*/
            /* Napisz kalkulator uwzględnij wyjątki
             * Dodaj menu wyboru dzialania
             * Użytkownik może zamknąć program wpisaując x
             */
            Console.WriteLine("Wybierz dzialanie:");
            int num, num1, num2;
            while (true)
            {
                string v = Console.ReadLine();
                try
                {
                    num = int.Parse(v);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    Console.WriteLine("Wybierz 1,2,3 lub 4\n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartosc nie może być pusta");
                }
                Console.WriteLine("Wprowadz poprawnie wartosc");
            }
            switch(num)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWybrales dodawanie\n");
                    Console.WriteLine("Wprowadz A:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Wprowadz B:");
                    string b = Console.ReadLine();
                    try
                    {
                        num1 = int.Parse(a);
                        num2 = int.Parse(b);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Wartosc nie może być pusta");
                    }
                    int dd = num1+num2;
                    Console.WriteLine("Wynik dodawania: {0}", dd);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWybrales odejmowanie\n");
                    Console.WriteLine("Wprowadz A:");
                    string c = Console.ReadLine();
                    Console.WriteLine("Wprowadz B:");
                    string d = Console.ReadLine();
                    try
                    {
                        num1 = int.Parse(c);
                        num2 = int.Parse(d);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Wartosc nie może być pusta");
                    }
                    int ddd = num1 - num2;
                    Console.WriteLine("Wynik dodawania: {0}", ddd);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWybrales mnożenien\n");
                    Console.WriteLine("Wprowadz A:");
                    string e = Console.ReadLine();
                    Console.WriteLine("Wprowadz B:");
                    string f = Console.ReadLine();
                    try
                    {
                        num1 = int.Parse(e);
                        num2 = int.Parse(f);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Wartosc nie może być pusta");
                    }
                    int dddd = num1 * num2;
                    Console.WriteLine("Wynik mnożenia: {0}", dddd);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWybrales dzielenie\n");
                    Console.WriteLine("Wprowadz A:");
                    string g = Console.ReadLine();
                    Console.WriteLine("Wprowadz B:");
                    string h = Console.ReadLine();
                    try
                    {
                        num1 = int.Parse(g);
                        num2 = int.Parse(h);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadz liczbe w poprawnym formacie np. 4\n");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Wprowadzona liczba jest poza zakresem dopuszalnym");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Wartosc nie może być pusta");
                    }
                    int ddddd = num1 / num2;
                    Console.WriteLine("Wynik dzielenia: {0}", ddddd);
                    break;
            }

            Console.ReadKey();

        }
    }
}
