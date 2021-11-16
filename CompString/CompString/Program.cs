using System;
using System.Text;

namespace CompString
{
    class CompStringDemo
    {
        //Статический метод для сравнения текстовы строк:
        static bool StrCmp(String X, String Y)
        {
            // Если строки разной длины:
            if (X.Length != Y.Length) return false;
            // Если строки одиноковой длины:
            for (int k = 0; k < X.Length; k++)
            {
                // Если  символы в текстовы строках разные:
                if (X[k] != Y[k]) return false;
            }

            return true;
        }
        
        
        
        public static void Main()
        {
            // Символьный массив:
            char[] smb = {'Я', 'з', 'ы', 'к', ' ', 'C', '#'};
            // Текстовый обьект:
            String A = "Язык C#";
            // Отображение текстовой строки:
            Console.WriteLine("A: \"{0}\"",A);
            // Создание нового текстового обьекта:
            String B = new String(smb);
            // Отображение ьестровой строки:
            Console.WriteLine("B: \"{0}\"",B);
            // Еще один текстовый обьект:
            String C = "ЯЗЫК C#";
            // Отображение текстовой строки:
            Console.WriteLine("C: \"{0}\"",C);
            Console.WriteLine("Сравненые строк");
            Console.WriteLine("A==B: {0}",A==B);
            Console.WriteLine("StrCmp(A,B): {0}",StrCmp(A,B));
            Console.WriteLine("A==C: {0}", A==C);
            Console.WriteLine("StrCmp(A,C): {0}", StrCmp(A,C));
            Console.WriteLine("B!=C: {0}",B!=C);
            Console.WriteLine("StrCmp(A,\"C#\"): {0}",StrCmp(A,"C#"));
        }
    }
}