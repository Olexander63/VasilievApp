using System;

namespace NestedTry
{
    internal class Program
    {
        static void generator(string num)
        {
            Console.WriteLine("Метод с аргументом \"{0}\" начинает работу",num);
            string msg = "Массив не создан!";
            try
            {
                int m = int.Parse(num);
                int[] array = new int [m];
                msg = "Создан массив:";
                for (int k = 0; k <= 4; k++)
                {
                    array[k] = 12 / (4 - k);
                    msg += " " + array[k];

                }

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка в методе: выходи за пределы массива");
            }
            finally
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("Метод завершил работу");
        }
        public static void Main()
        {
            string[] args = {"один", "-2", "5", "2"};
            char[] symbs = new char[1];
            for (int k = 0; k < args.Length; k++)
            {
                try
                {
                    Console.WriteLine("Выполняется цикл №{0}:",k+1);
                    try
                    {
                        generator(args[k]);
                        symbs[1] = 'A';
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Первый внутренний cath-блок: {0}", e.GetType().Name);

                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Второй внутреннийй cath-блок: {0}", e.GetType().Name);
                    }
                    finally
                    {
                        symbs[0] = (char) ('A' + k);
                        Console.WriteLine("Символ: \'{0}\'",symbs[0]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Внешний catch-блок: {0}",e.GetType().Name);
                }

                Console.WriteLine("Цикл №{0} завершен... \n",k+1);
            }
        }
    }
}