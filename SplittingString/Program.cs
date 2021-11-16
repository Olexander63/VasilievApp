using System;

namespace SplittingString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Исходная текстовая строка:
            String txt = "Дорогогу осилит идущий";
            // Отображение исходного текста:
            Console.WriteLine(txt);
            // Текстовая строка:
            String str;
            // Текст с симваолами в верхнем регистре:
            str = txt.ToUpper();
            // Провекатекстового значения:
            Console.WriteLine(str);
            // Текст с символами в нижнем регистре:
            str = txt.ToLower();
            // Проверка текстового значения:
            Console.WriteLine(str);
            // Переменная для тексогового массива:
            String[] words;
            // Розбивка текста на подстроки:
            words = txt.Split();
            // отображение подстрок:
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k +1)+": " +words[k]);
            }

            Console.WriteLine();
            // розбивка текста на подстроки:
            words=txt.Split('у','и');
            // Отображение подстрок:
            for(int k=0;k<words.Length;k++){
                Console.WriteLine((k+1)+": "+words[k]);
            }

            Console.WriteLine();
            // Разбивка текста на подстроки:
            words=txt.Split(new char[]{'у','и'},3);
            // Отображение подстрок:
            for(int k=0;k<words.Length;k++){
                Console.WriteLine((k+1)+": "+words[k]);
            }
            // Переменная для симвоьного массива:
            char[] symbs;
            // Массив из символов, формирующих текст:
            symbs = txt.ToCharArray();
            // Отображение символов из массива:
            for (int k = 0; k <symbs.Length; k++)
            {
                Console.Write(symbs[k]+" ");
            }

            Console.WriteLine();
        }
    }
}