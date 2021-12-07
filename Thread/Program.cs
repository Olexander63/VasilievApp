using System;

namespace Thread
{
    internal class Program
    {
        static void run()
        {
            Console.WriteLine("Запускаем дочерний поток");
            for (int k = 0; k <=5; k++)
            {
                Console.WriteLine("Дочерний поток: {0}",(char)('A'+k));
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Дочерний поток завершен");
        }
        static void Main()
        {
            Console.WriteLine("Запускаем главный поток");
            System.Threading.Thread mt = new System.Threading.Thread(run);
            mt.Start();
            for (int k = 1; k <=5 ; k++)
            {
                Console.WriteLine("Главынй поток: "+ k);
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine("Главный поток завершен");
        }
    }
}