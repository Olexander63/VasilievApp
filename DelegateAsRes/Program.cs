using System;

namespace DelegateAsRes
{
    delegate int Method(int n);

    class MyClass
    {
        private int num;

        public MyClass(int n)
        {
            num = n;
        }

        private int first(int n)
        {
            return n + num;
        }

        private int second(int n)
        {
            return n - num;
        }

        private int third(int n)
        {
            return n * num;
        }

        public Method this[int k]
        {
            get
            {
                switch (k)
                {
                    case  0:
                        return first;
                    case 1:
                        return second;
                    default:
                        return
                            third;
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 12;
            MyClass obj = new MyClass(4);
            for (int k = 0; k <=2; k++)
            {
                Console.WriteLine("obj[{0}]({1}) = {2}", k,x,obj[k](x));
            }
        }
    }
}