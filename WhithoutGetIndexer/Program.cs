using System;

namespace WhithoutGetIndexer
{
    class MyString
    {
        private string text;

        public MyString(string t)
        {
            text = t;
        }

        public static implicit operator MyString(string t)
        {
            return new MyString(t);
        }

        public override string ToString()
        {
            return text;
        }

        public char this[int k]
        {
            set
            {
                if(k<0||k>=text.Length) return;
                string t = "";
                for (int i = 0; i < k; i++)
                {
                    t += text[i];
                }

                t += value;
                for (int i = k+1; i <text.Length; i++)
                {
                    t += text[i];
                }

                text = t;
            }
            
        }
    }
    
    
   
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Создание объекта:
            MyString txt="Муха";
            // Проверка текста:
            Console.WriteLine(txt);
            // Попытка изменить символ в тексте:
            txt[-1]='Ы';
            // Проверка текста:
            Console.WriteLine(txt);
            // Попытка изменить символ в тексте:
            txt[4]='Ъ';
            // Проверка текста:
            Console.WriteLine(txt);
            // Изменение символа в тексте:
            txt[0]='C';
            // Проверка текста:
            Console.WriteLine(txt);
            // Изменение символа в тексте:
            txt[1]='л';
            // Проверка текста:
            Console.WriteLine(txt);
            // Изменение символа в тексте:
            txt[2]='о';
            // Проверка текста:
            Console.WriteLine(txt);
            // Изменение символа в тексте:
            txt[3]='н';
            // Проверка текста:
            Console.WriteLine(txt);
        }
    }
}