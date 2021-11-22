using System;

namespace InheritAndConst
{
    class Alpha
    {
        public int code;

        public Alpha(int n)
        {
            code = n;
            Console.WriteLine("Alpha (один аргумент) : {0}", code);
        }

        public Alpha()
        {
            code = 123;
            Console.WriteLine("Alpha без аргументов) : {0}", code);
        }
    }

    class Bravo: Alpha
    {
        public char symb;

        public Bravo(int n, char s) : base(n)
        {
            symb = s;
            Console.WriteLine("Bravo (два аргумента): {0} и \'{1}\'",code,symb);
        }

        public Bravo(int n) : base(n)
        {
            symb = 'A';
            Console.WriteLine("Bravo (int - аргумент){0} \'{1}\'", code,symb);
        }

        public Bravo(char s) : base(321)
        {
            symb = s;
            Console.WriteLine("Bravo (char -аргумент): {0}  и \'{1}\'",code,symb);
        }

        public Bravo() : base()
        {
            symb = 'O';
            Console.WriteLine("Bravo (без аргументов): {0} и \'{1}\'",code,symb);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alpha Al = new Alpha();
            Console.WriteLine();
            Alpha A2 = new Alpha(100);
            Console.WriteLine();

            Bravo B1 = new Bravo(200,'B');
            Console.WriteLine();
            Bravo B2 = new Bravo(300);
            Console.WriteLine();
            Bravo B3 = new Bravo('C');
            Console.WriteLine();
            Bravo B4 = new Bravo();
        }
    }
}