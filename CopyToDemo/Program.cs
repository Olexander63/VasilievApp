using  System;
using  System.IO;

namespace CopyToDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string f = "C:/Users/Oleksandr/Pictures/csharp/bear.png";
            string F = "C:/Users/Oleksandr/Pictures/csharp/Books/animal.png";
            try
            {
                FileStream fin = new FileStream(f, FileMode.Open);
                Console.WriteLine("Исходный файл: \"{0}\"",f);
                FileStream fout = new FileStream(F, FileMode.Create);
                Console.WriteLine("Новый файл: : \"{0}\"",F);
                fin.CopyTo(fout);
                fout.Close();
                fin.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка!");
                Console.WriteLine();
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Копирование успешно завершено");
        }
    }
}