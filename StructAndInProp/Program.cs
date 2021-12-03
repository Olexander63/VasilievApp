using System;

namespace StructAndInProp
{
    struct MyStruct
    {
        private string txt;

        public string text
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }

        public int length => text.Length;

        public char this[int k]
        {
            get
            {
                return txt[k];
            }
            set
            {
                char[] s = text.ToCharArray();
                s[k] = value;
                text = new string(s);
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStruct A = new MyStruct();
            A.text = "Alpha";
            Console.WriteLine(A.text);
            for (int k = 0; k < A.length; k++)
            {
                Console.Write("|"+A[k]);
            }

            Console.WriteLine("|");
            A[0] = 'a';
            A[A.length - 1] = 'A';
            Console.WriteLine(A.text);
        }
    }
}