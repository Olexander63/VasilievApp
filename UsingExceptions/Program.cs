using System;

namespace UsingExceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums;
            int x, n;
            for (int k = 1; k < 10; k++)
            {
                Console.Write("[{0}]",k);
                n = 1;
                try
                {
                    nums = new int[2 * rnd.Next(3) - 1];
                    n++;
                    x = 1 / rnd.Next(3);
                    n++;
                    nums[rnd.Next(2) - 1] = x;
                    n++;
                    nums[0] = int.Parse("ноль");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Команда №{0}: ",n);
                    Console.WriteLine(e.GetType().Name);
                    Console.WriteLine(" - "+e.Message);
                }
            }
        }
    }
}