using System;

namespace StructAndPointers
{
    struct MyStruct
    {
        public int code;

        public void show()
        {
            Console.WriteLine("Поле code: "+ code);
        }
    }
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            MyStruct A, B;
            MyStruct* p;
            p = &A;
            p->code = 123;
            p->show();
            A.show();
            Console.WriteLine("--------");
            p = &B;
            p->code = 321;
            p->show();
            B.show();
            Console.WriteLine("--------");
            (*p).code = 456;
            (*p).show();
            B.show();
        }
    }
}