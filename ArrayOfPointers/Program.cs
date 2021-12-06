using System;

namespace ArrayOfPointers
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 100, y = 200, z = 300;
            int*[] nums = new int*[3];
            nums[0] = &x;
            nums[1] = &y;
            nums[2] = &z;
            Console.WriteLine( " Числа: {0},{1} {2}",nums[0][0],*nums[1],nums[2][0]);
            char*[] symbs = new char*[3];
            symbs[0] = (char*) &x;
            symbs[1] = (char*) &y;
            symbs[2] = (char*) &z;
            char s = 'A';
            for (int i = 0; i < symbs.Length; i++)
            {
                for (int j = 0; j < sizeof(int)/sizeof(char); j++)
                {
                    symbs[i][j] = s;
                    s++;
                    Console.Write(symbs[i][j]+" ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Числа :{0},{1}, {2}",x,y,x);
            Console.WriteLine("Проверка: {0},{1} {2}",nums[0][0],*nums[1],nums[2][0]);
            Console.WriteLine(" Еще раз:{0},{1} и {2}",*(int*)symbs[0],*(int*)symbs[1],*(int*)symbs[2]);
            Console.WriteLine(" Для сравнениея: {0},{1} и {2}",*symbs[0],*symbs[1],*symbs[2]);
        }
    }
}