using System;

namespace StructToString
{
    struct MyStruct
    {
        public string name;
        public int code;

        public MyStruct(string name, int code)
        {
            this.name = name;
            this.code = code;
        }

        public override string ToString()
        {
            string txt = "Экземпляр \"" + name + "\"\n";
            txt += "Числовое поле: " + code + "\n";
            return txt;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStruct A = new MyStruct("Alpha", 100);
            MyStruct B = new MyStruct("Bravo", 200);
            Console.WriteLine(A);
            string text = B + "Выполение программы завершено";
            Console.WriteLine(text);
        }
    }
}