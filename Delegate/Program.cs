using System;

namespace Delegate
{
    delegate char MyDelegate(int k, string txt);

    class MyClass
    {
        public int code;

        public MyClass(int n)
        {
            code = n;
        }

        public char getChar(int k, string txt)
        {
            return (char) (txt[k] + code);
        }

        public static char getFirst(int k, string txt)
        {
            return txt[k];
        }
    }

    class DelegateDemo
    {
        public static char getLast(int k,string txt)
        {
            return txt[txt.Length-k-1];
        }
    }

    class Program
    {
        public static void Main()
        {
            MyClass obj=new MyClass(5);
            MyDelegate meth=new MyDelegate(obj.getChar);
            Console.WriteLine("Символ \'{0}\'", meth(4, "Alpha"));
            obj.code = 1;
            Console.WriteLine("Символ \'{0}\'", meth(4, "Alpha"));
            meth = MyClass.getFirst;
            Console.WriteLine("Символ \'{0}\'", meth(2, "Alpha"));
            meth = DelegateDemo.getLast;
            Console.WriteLine("Символ \'{0}\'", meth(1, "Alpha"));
        }
    }
}