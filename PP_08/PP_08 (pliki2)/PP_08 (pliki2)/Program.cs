using System;
using System.IO;
using System.Text;
namespace PP_08__pliki2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\student\C#Files";
            int x;
            Console.WriteLine("Czy chcesz usunać plik?");
            Console.ReadLine();
            switch(x)
            {
                case 1:
                    {
                        try
                        {
                            if (Directory.Exists(path))
                            {
                                Console.WriteLine("\nKatalog istnieje");
                            }
                            else
                            {
                                Directory.CreateDirectory("\\Users\\Student\\C#Files");
                                string textFilePath = @"C:\Users\student\C#Files\testFile1.txt";
                                File.WriteAllLines(textFilePath, customers);

                                Console.WriteLine("\nUtworzono katalog: {0}", Directory.GetCreationTime(path));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: {0}", e.ToString());
                            
                        }
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine("Nie usunąłeś pliku");
                        break;
                    }
                
            }

            if(Directory.Exists(path))
            {
                Console.WriteLine("\nCzy chcesz usunac kltalaog?");
                string delete = Console.ReadLine();
                if(delete ==  "1")
                {
                    Directory.Delete(path, true);
                    if(Directory.Exists(path))
                    {
                        Console.WriteLine("Katalog usuniety");
                    }
                }
                else
                {
                    Console.WriteLine("Nie usunąłęś katalogu");
                }
            }
            



            Console.ReadLine();
        }
    }
}
