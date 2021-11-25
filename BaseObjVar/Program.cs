using System;

namespace BaseObjVar
{
    class Base
    {

        public int code;

        public void show()
        {
            Console.WriteLine("Поле code: "+ code);
        }

        public Base(int n)
        {
            code = n;
        }

        public Base(Base obj)
        {
            code = obj.code;
        }
    }

    class MyClass: Base
    {
        public char symb;

        public void display()
        {
            Console.WriteLine("Поле symb : "+ symb);
        }

        public MyClass(int n, char s) : base(n)
        {
            symb = s;
        }

        public MyClass(MyClass obj) : base(obj)
        {
            symb = obj.symb;
        }
    }
    internal class Program
    {
        public static void Main()
        {
            MyClass A = new MyClass(100, 'A');
            Base obj;
            obj = A;
            Console.WriteLine("Используем переменную obj:");
            obj.show();
            ((MyClass)obj).display();
            obj.code = 200;
            ((MyClass) obj).symb = 'B';
            Console.WriteLine("Используем переменную A:");
            A.show();
            A.display();

            MyClass B = new MyClass(A);
            A.code = 0;
            A.symb = 'O';
            Console.WriteLine("Используем переменную B: ");
            B.show();
            B.display();
        }
    }
}