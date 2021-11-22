using System;

namespace UsingIndexer
{
    class MyClass
    {
        private int[] nums;

        public MyClass(int  n)
        {
            nums = new int[n];

            for (int k = 0; k <nums.Length; k++)
            {
                nums[k] = 0;
            }
        }

        public override string ToString()
        {
            string txt = "{" + nums[0];
            for (int k = 1; k < nums.Length; k++)
            {
                txt += "," + nums[k];
            }

            txt += "}";
            return txt;
        }

        public int length
        {
            get
            {
                return nums.Length;
            }
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
    class Program
    {
        public static void Main()
        {
            MyClass obj = new MyClass(5);
            Console.WriteLine(obj);
            for (int k = 0; k < obj.length; k++)
            {
                obj[k] = 2 * k + 1;
            }

            Console.WriteLine(obj);
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write(" "+ obj[k]);
            }

            Console.WriteLine();
        }
    }
}