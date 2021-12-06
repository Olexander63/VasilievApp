using System;

namespace MyException
{
    class MyException:ApplicationException
    {
        private int code;

        public MyException(int n, string txt) : base(txt)
        {
            code = n;
        }

        public override string ToString()
        {
            string res = Message + "\nКод ошибки: " + code;
            return res;
        } 
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new MyException(123, "Большая ошибка");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}