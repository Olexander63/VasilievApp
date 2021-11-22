using System;

namespace Inherit
{
    class Base
    {
        public int code;

        public void show()
        {
            Console.WriteLine("Поле code:" + code);
        }
    }

    class MyClass: Base
    {
        public char symb;

        public void display()
        {
            Console.WriteLine("Поле symb: " + symb);
            show();
        }

        public int number
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.code = 100;
            obj.symb = 'A';
            obj.display();
            obj.number = 200;
            Console.WriteLine("Свойство number: " +obj.number);
            
            obj.show();

        }
    }
}