using System;

namespace Interface
{
    interface MyInterface
    {
        void show();
        void setNum(int n);
        int getNum();

        int number
        {
            get;
            set;
        }

        int this[int k]
        {
            get;
        }
    }

    class MyClass:MyInterface
    {
        private int num;

        public MyClass(int n)
        {
            number = n;
            show();
        }

        public void show()
        {
            Console.WriteLine(" Свойство number "+ number);
        }

        public void setNum(int n)
        {
            num = n;
        }

        public int getNum()
        {
            return num;
        }

        public int number
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
    class Program
    {
        public static void Main(string[] args)
        {
            int m = 9;
            MyClass obj = new MyClass(12345);
            for (int i = 0; i <=m; i++)
            {
                Console.Write("|" + obj[m-i]);
            }

            Console.WriteLine("|");
        }
    }
}