using System;

namespace StructAsResult
{
    struct MyStruct
    {
        public char[] name;
        public int code;

        public MyStruct(char[] s, int n)
        {
            name = s;
            code = n;
        }

        public void show()
        {
            Console.Write("Массив: ");
            for (int k = 0; k < name.Length; k++)
            {
                Console.Write("|"+name[k]);
            }

            Console.WriteLine("|\n Числовое поле: {0}",code);
        }
    }
    internal class Program
    {
        static MyStruct create(string t, int n)
        {
            char[] s = t.ToCharArray();
            MyStruct R = new MyStruct(s, n);
            return R;
        }
        public static void Main(string[] args)
        {
            MyStruct A;
            A = create("Apha", 100);
            A.show();
            create("Bravo",200).show();
        }
    }
}