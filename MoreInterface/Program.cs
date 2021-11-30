using System;

namespace MoreInterface
{
    abstract class Base
    {
        public abstract int number
        {
            get;
            set;
        }

        public Base(int n)
        {
            number = n;
            show();
        }

        public void show()
        {
            Console.WriteLine("Свойство number="+ number);
        }
    }

    interface First
    {
        void setNum(int n);
        int getNum();
    }

    interface Second
    {
        int this[int k]
        {
            get;
        }
    }

    class MyClass:Base,First,Second
    {
        private int num;
        public MyClass(int n):base(n){}

        public void setNum(int n)
        {
            num = n;
        }

        public int getNum()
        {
            return num;
        }

        public override int number
        {
            get
            {
                return getNum();
            }
            set
            {
                setNum(value);
            }
        }

        public int this[int k]
        {
            get
            {
                int r = number;
                for (int i = 0; i < k; i++)
                {
                    r /= 10;
                }

                return r % 10;
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int m = 9;
            MyClass obj = new MyClass(12345);
            for (int i = 0; i < m; i++)
            {
                Console.Write("|"+ obj[m-i]);
            }

            Console.WriteLine("|");
        }
    }
}