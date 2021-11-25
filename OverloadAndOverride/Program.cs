using System;

namespace OverloadAndOverride
{
    class Alpha
    {
        public int alpha;

        public void set()
        {
            alpha = 10;
            Console.WriteLine("Alpha (без аргументов): {0} ", alpha);
        }

        public virtual void set(int n)
        {
            alpha = n;
            Console.WriteLine("Alpha (один аргумент): {0}", alpha);
        }
    }

    class Bravo: Alpha
    {
        public int bravo;

        public override void set(int n)
        {
            alpha = n;
            bravo = alpha;
            Console.WriteLine("Bravo (один аргумент): {0}  и {1} ", alpha, bravo);
        }

        public void set(int m, int n)
        {
            alpha = m;
            bravo = n;
            Console.WriteLine("Bravo (два аргументами) ", alpha, bravo);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alpha A = new Alpha();
            A.set();
            A.set(20);
            Console.WriteLine();

            Bravo B = new Bravo();
            B.set();
            B.set(30);
            B.set(40,50);
        }
    }
}