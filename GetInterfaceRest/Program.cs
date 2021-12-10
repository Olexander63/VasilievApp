using System;

namespace GetInterfaceRest
{
    interface Myinterface<T> where T : struct
    {
        void show();
    }
    class MyClass<T> : Myinterface<T> where T : struct
    {
        public T val;
        public MyClass(T v)
        {
            val = v;
        }
        public void show()
        {
            Console.WriteLine("Тип {0}: значение {1}", typeof(T).Name, val);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> A = new MyClass<int>(100);
            MyClass<char> B = new MyClass<char>('B');
            A.show();
            B.show();
        }
    }
}
