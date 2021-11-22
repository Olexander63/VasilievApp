using System.Net.Sockets;
using System;

namespace UsingTwoDimIndexer
{
    class MyClass
    {
        private int[] vals;
        private char[] ckey;
        private string[] skey;

        private void add(char a, string b, int n)
        {
            int size;
            char[] s;
            string[] t;
            int[] v;
            if (vals == null) size = 1;
            else size = vals.Length;
            s = new char[size];
            s[s.Length - 1] = a;
            t = new string[size];
            t[t.Length - 1] = b;
            v = new int[size];
            v[v.Length - 1] = n;

            for (int k = 0; k < size - 1; k++)
            {
                s[k] = ckey[k];
                t[k] = skey[k];
                v[k] = vals[k];
            }

            ckey = s;
            skey = t;
            vals = v;
        }

        public override string ToString()
        {
            string txt = "Содержимое обьекта:\n";
            if (vals != null)
            {
                for (int k = 0; k < ckey.Length; k++)
                {
                    txt += ckey[k] + ": " + skey[k] + ": " + vals[k] + "\n";
                }
            }
            else
            {
                txt += "пустой обьект\n";
            }

            return txt;
        }

        public int this[char a, string b]
        {
            // Метод вызывается при считывании значения
            // выражения с проиндексированным объектом:
            get
            {
                // Если массив существует:
                if (vals != null)
                {
                    // Перебор элементов массива:
                    for (int k = 0; k < ckey.Length; k++)
                    {
                        // Если элемент найден:
                        if (a == ckey[k] && b == skey[k])
                        {
                            // Значение выражения:
                            return vals[k];
                        }
                    }
                }

                // Код выполняется, если массив не существует или
                // если элемент не найден:
                int res = 0; // Значение для нового элемента
                add(a, b, res); // Добавление нового элемента
                return res; // Значение выражения
            }
            set
            {
                if (value!=null)
                {
                    for (int k = 0; k < ckey.Length; k++)
                    {
                        if (a == ckey[k] && b == skey[k])
                        {
                            vals[k] = value;
                            return;
                        }
                    }
                }
                add(a,b,value);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Создание объекта:
            MyClass obj=new MyClass();
            // Проверка содержимого объекта:
            Console.WriteLine(obj);
            // Проверка значения элемента:
            Console.WriteLine("Значение элемента: "+obj['A',"Первый"]+"\n");
            // Проверка содержимого объекта:
            Console.WriteLine(obj);
            // Присваивание значения элементу:
            obj['B',"Второй"]=200;
            // Присваивание значения элементу:
            obj['C',"Третий"]=300;
            // Проверка содержимого объекта:
            Console.WriteLine(obj);
            // Проверка значения элемента:
            Console.WriteLine("Значение элемента: "+obj['B',"Первый"]+"\n");
            // Проверка значения элемента:
            Console.WriteLine("Значение элемента: "+obj['B',"Второй"]+"\n");
            // Проверка значения элемента:
            Console.WriteLine("Значение элемента: "+obj['A',"Третий"]+"\n");
            // Проверка содержимого объекта:
            Console.WriteLine(obj);
            // Присваивание значения элементу:
            obj['A',"Первый"]=100;
            // Проверка содержимого объекта:
            Console.WriteLine(obj);
            // Проверка значения элемента:
            Console.WriteLine("Значение элемента: "+obj['A',"Первый"]+"\n");
        }
    }
}