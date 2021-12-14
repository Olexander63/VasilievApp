using System;
using System.IO;

namespace FileStreamDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string pathFrom = "C:/Users/Oleksandr/Pictures/csharp/";
            string pathTo = "C:/Users/Oleksandr/Pictures/csharp/Books/";
            string file = "bear.png";
            string name = "animal.png";
            string f = pathFrom + file;
            string F = pathTo + name;
            try
            {
                FileStream fin = new FileStream(f, FileMode.Open);
                Console.WriteLine("Исходный файл: \"{0}\"",f);
                FileStream fout = new FileStream(F, FileMode.Create);
                Console.WriteLine("Новий файл: \"{0}\"",F);
                int val;
                val = fin.ReadByte();
                while (val!= 1)
                {
                    fout.WriteByte((byte)val);
                    val = fin.ReadByte();
                }
                fout.Close();
                fin.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка!");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Копирование успешно завершено");
        }
    }
}