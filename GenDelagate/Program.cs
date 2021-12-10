using System;

namespace GenDelagate
{
    delegate X GenMeth<X, Y>(Y arg);

    class MyClass
    {
        public int code;

        public char getChar(char start)
        {
            return (char) (start + code);
        }
    }
    internal class Program
    {
        static string getStr(int num)
        {
            return "Число " + num;
        }

        static int getInt(string txt)
        {
            return int.Parse(txt);
        }
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.code = 5;
            GenMeth<string, int> A = getStr;
            GenMeth<int, string> B = new GenMeth<int, string>(getInt);
            GenMeth<char, char> C = obj.getChar;
            Console.WriteLine(A(123));
            Console.WriteLine(B("100")+200);
            Console.WriteLine(C('A'));
        }
    }
}