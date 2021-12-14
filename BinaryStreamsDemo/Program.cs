using System;
using System.IO;

namespace BinaryStreamsDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 123;
            char symb = 'A';
            double x = 2.5;
            string txt = "Hello,Wolrd!";
            string file = "C:/Users/Oleksandr/Pictures/csharp/MyData.dat";
            Console.WriteLine("Запись данных в файл");
            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
                bw.Write(num);
                bw.Write(symb);
                bw.Write(x);
                bw.Write(txt);
                bw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка записи в файл!");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Создан файл \"{0}\"",file);
            Console.WriteLine("Считывание данных из файла...");
            try
            {
                BinaryReader br = new BinaryReader(new FileStream(file, FileMode.Open));
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadChar());
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadString());
                br.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтенние файла!");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Завершение программы...");
        }
    }
}