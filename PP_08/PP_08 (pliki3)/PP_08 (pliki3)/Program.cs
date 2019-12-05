using System;
using System.IO;
using System.Text;
namespace PP_08__pliki3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\student\C#Files";
            DirectoryInfo myDataDir = new DirectoryInfo(@path);
            Console.WriteLine();
            FileInfo[] txtfiles = myDataDir.GetFiles("*.txt" ,SearchOption.AllDirectories);
            Console.WriteLine( "Ilosc plikow tekstowych: {0} \n", txtfiles.Length);
            Console.WriteLine("Pliki textowe: ");
            foreach (FileInfo file in txtfiles)
            {
                Console.WriteLine("Nazwa: {0}" );
            }
            //copy con nazwa.txt
            //fsdfsf
            //dwwqqw
            //eqeqeq [enter]
            Console.WriteLine("Hello World!");
            
        }
    }
}
