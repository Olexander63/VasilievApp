using System;

namespace PrivateAndProtected
{
    class Alpha
    {
        private int num;

        protected char symb;

        public int getNum()
        {
            return num;
        }

        public char getSymb()
        {
            return symb;
        }

        public void setNum(int n)
        {
            num = n;
        }

        public void setSymb(char s)
        {
            symb = s;
        }
    }

    class Bravo: Alpha
    {
        public char symbol
        {
            get
            {
                return symb;
            }
            set
            {
                symb = value;
            }
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
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alpha A = new Alpha();
            A.setNum(100);
            A.setSymb('A');
            Console.WriteLine("Обьект A: {0} и {1}", A.getNum(),A.getSymb());
            Bravo B = new Bravo();
            B.setNum(200);
            B.setSymb('B');
            Console.WriteLine("Обьект B: {0} {1}", B.getNum(), B.getSymb());
            B.number = 300;
            B.symbol = 'C';
            Console.WriteLine("Обьект B: {0} и {1}", B.number,B.symbol);
        }
    }
}