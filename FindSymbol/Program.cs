using System;

namespace FindSymbol
{
    internal class Program
    {
        static int find(string txt, char s)
        {
            for (int k = 0; k < txt.Length; k++)
            {
                if (txt[k] == s) return k;
            }

            throw new Exception("Символа \'" + s + "\' в тексте \"" + txt + "\" нет");
        }
        public static void Main(string[] args)
        {
            string txt;
            char s;
            int index;
            try
            {
                Console.Write("ВВедите текст: ");
                txt = Console.ReadLine();
                Console.Write("Введите символ");
                s = (char) Console.Read();
                index = find(txt, s);
                Console.WriteLine("Индекс символа "+ index);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}