using System;

namespace WhileAndException
{
    class MyClass
    {
        private int[] nums;

        public MyClass(int size)
        {
            nums = new int[size];
        }

        public int this[int k]
        {
            get
            {
                return nums[k];
            }
            set
            {
                nums[k] = value;
            }
        }
    }
    internal class Program
    {
        static void show(MyClass obj)
        {
            int k = 0;
            try
            {
                while (true)
                {
                    Console.Write("|" + obj[k]);
                    k++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("|");
            }
        }
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass(10);
            int k = 0;
            try
            {
                do
                {
                    obj[k] = 2 * k + 1;
                    k++;
                } while (true);

            }
            catch (IndexOutOfRangeException)
            {
                show(obj);
            }
        }
    }
}