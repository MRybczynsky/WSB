using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_05_wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {
                Console.Write("Wprowadz liczbe calkowita: ");
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    //Console.WriteLine("Error");
                    Console.WriteLine(); 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine("Podales bledne dane: {0} ", x);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidlowe dane: {0}", number);
            


            Console.ReadKey();

        }
    }
}
