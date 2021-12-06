using System;

namespace Checked
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte a = 100, b = 200, c;
            try
            {
                c = checked((byte) (a + b));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Есть ошибка:"+(a+b));
            }

            c = unchecked((byte) (a + b));
            Console.WriteLine("Нет ошибки: "+c);
        }
    }
}