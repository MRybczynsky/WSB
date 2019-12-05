using System;
using System.IO;
using System.Text;
namespace PP_08__pliki1_
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            Console.WriteLine(wsbDir.FullName);

            //DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student\\Desktop");
            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student");
            
            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent); //katalog nadrzedny
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");
            string[] customers =
            {
                "Agnieszka Nowak",
                "Anna Nowak",
                "Tomasz Kowalski",
            };


            string path = @"C:\Users\student\C#Files";

            try
            {
                if(Directory.Exists(path))
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
            
           

            Console.ReadLine();
        }
    }
}
