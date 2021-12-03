using System;

namespace Struct
{
    struct MyStruct
    {
        public int code;
        public string name;

        public MyStruct(int n, string t)
        {
            code = n;
            name = t;
        }

        public void show()
        {
            Console.WriteLine("Поля \"{0}\" и {1}",name,code);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStruct A;
            A.code = 100;
            A.name = "Экземпляр А";
            A.show();
            MyStruct B = new MyStruct(200, "Экземпляр B");
            B.show();
            A = B;
            B.code = 300;
            A.show();
            B.show();
            
        }
    }
}