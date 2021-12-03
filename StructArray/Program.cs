using System;

namespace StructArray
{
    struct MyStruct
    {
        public int code;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int size = 7;
            MyStruct[] A = new MyStruct[size];
            for (int k = 0; k < A.Length; k++)
            {
                A[k].code = 2 * k + 1;
                Console.Write("|"+A[k].code);
            }

            Console.WriteLine("|");
        }
    }
}