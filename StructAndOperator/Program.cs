namespace StructAndOperator
{
    struct Mynum
    {
        private int number;

        public Mynum(int n)
        {
            number = n;
        }

        public static int operator +(Mynum A, int n)
        {
            return !A + n;
        }

        public static int operator +(int n, Mynum A)
        {
            return A + n;
        }

        public static int operator +(Mynum A, Mynum B)
        {
            return !A + !B;
        }
        public st
        
        public static  int operator
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}