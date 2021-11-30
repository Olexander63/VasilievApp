using System;

namespace InterfaceVar
{
    
    
    interface MyInterface
    {
        char getChar(int n);
        char this[int k]
        {
            get;
        }
    }

    class Alpha:MyInterface
    {
        private char symb;

        public Alpha(char s)
        {
            symb = s;
        }

        public char getChar(int n)
        {
            return (char) (symb + n);
        }

        public char this[int k]
        {
            get
            {
                return getChar(k);
            }
        }
    }

    class Bravo:MyInterface
    {
        private string text;

        public Bravo(string t)
        {
            text = t;
        }

        public char getChar(int k)
        {
            return text[k % text.Length];
        }

        public char this[int k]
        {
            get
            {
                return getChar(k);
            }
        }
    }
   class Program
    {
        public static void Main(string[] args)
        {
            int m = 5;
            MyInterface R;
            R = new Alpha('F');
            Console.WriteLine("Символы от \'{0}\' до \'{1}\':", R.getChar(-m),R.getChar(m));
            for (int i = -m; i <=m; i++)
            {
                Console.Write("|" + R[i]);
            }

            Console.WriteLine("|");
            R = new Bravo("bravo");
            Console.WriteLine("Символы от \'{0}\' до \'{1}\':",R.getChar(0),R.getChar(2*m+1));

            for (int i = 0; i <=2*m+1 ; i++)
            {
                Console.Write("|"+R[i]);
            }

            Console.WriteLine("|");
        }
    }
}