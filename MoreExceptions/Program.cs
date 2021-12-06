using System;

namespace MoreExceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums;
            int x;
            for (int k = 1; k < 10; k++)
            {
                Console.Write("[{0}]",k);
                try
                {
                    nums = new int[2 * rnd.Next((3) - 1)];
                    x = 1 / rnd.Next(3);
                    nums[rnd.Next(2) - 1] = x;
                    nums[0] = int.Parse("ноль");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка №1: Неверный размер массива");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка №2: Деление на ноль");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка №3: Неверный индекс элемента");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка №4: Неверный  формат числа");
                }

            }
        }
    }
}