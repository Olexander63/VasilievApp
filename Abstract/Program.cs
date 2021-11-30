using System;
namespace Abstract
{
    abstract class Base
    {
        protected int num;

        public Base(int n)
        {
            set(n);
        }

        public abstract void show();
        public abstract void set(int n);
        public abstract int get();
    }

    class Alpha:Base
    {
        protected int val;

        public Alpha(int n) : base(n)
        {
            show();
        }

        public override void show()
        {
            Console.WriteLine("Alpha: {0}, {1} and {2}", num,val,get());
        }

        public override void set(int n)
        {
            num = n;
            val = n % 10;
        }

        public override int get()
        {
            return num / 10;
        }
    }

    class Bravo:Base
    {
        protected int val;

        public Bravo(int n) : base(n)
        {
            show();
        }

        public override void show()
        {
            Console.WriteLine("Bravo: {0}, {1} and {2}", num,val,get());
        }

        public override void set(int n)
        {
            num = n;
            val = n % 100;
        }

        public override int get()
        {
            return num / 100;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Base obj;
            Alpha A = new Alpha(123);
            Bravo B = new Bravo(321);
            obj = A;
            Console.WriteLine("После выполнения команды obj=A");
            obj.set(456);
            obj.show();
            obj = B;
            Console.WriteLine("После выполнения команды obj=B");
            obj.set(654);
            obj.show();
        }
    }
}