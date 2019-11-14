using System;

namespace PP_06_funkcja1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            Show();
            Console.WriteLine(Show1());
            Add(4,8);
            Add(1,2,3);
            Console.WriteLine("WYWYOLANIE FUNKCJI 4 ARGUMENTOWEJ");
            Console.WriteLine(Add(1,2,3,4));
            Console.WriteLine(Add(d:3, a:2));

            Console.ReadKey();
        }
        static void Show()
        {
            Console.WriteLine("WSB");
        }
        static int Show1()
        {
            return 0;
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania {1} i {2} : {0}", result,a,b);
        }

        static void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik dodawania {1}, {2} oraz {3} : {0}", result,a,b,c);

        }

        static void Add(int a, int d, int b=5, int c=5) //przypisane paramatery na koncu!!!
        {
            return a + b + c + d;
        }
    }
}
