using System;

namespace Throw
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Сейчас будет ошибка...");
                    throw new ArgumentException("Какая-то ошибка");
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Еще раз: \"{0}\"",e.Message);
            }
        }
    }
}