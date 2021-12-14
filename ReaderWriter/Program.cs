using System;
using System.IO;

namespace ReaderWriter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string file = "C:/Users/Oleksandr/Pictures/csharp/MyText.txt";
            string str;
            string word = "exit";
            int k = 1;
            try
            {
                StreamWriter fw = new StreamWriter(file);
                Console.WriteLine("Для завершения введите  \"{0}\"",word);
                do
                {
                    Console.Write("{0}- я строка: >", k);
                    k++;
                    str = Console.ReadLine();
                    if (str == word)
                    {
                        break;
                    }
                    else
                    {
                        fw.WriteLine(str);
                    }
                } while (true);

                fw.Close();
                Console.WriteLine("Файл создан!");
                StreamReader fr = new StreamReader(file);
                Console.WriteLine("Содержимое файлф");
                    str= fr.ReadLine();
                    while (str!= null)
                    {
                        Console.WriteLine(str);
                        str = fr.ReadLine();
                    }
                    fr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка");
                Console.WriteLine(e.Message);
            }
        }
    }
}